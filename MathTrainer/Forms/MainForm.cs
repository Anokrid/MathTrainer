using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using MathTrainer.Enums;

namespace MathTrainer
{
    /// <summary>
    /// Основное окно приложения
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        #region Закрытые и открытые поля
        /// <summary>
        /// Максимальное количество выводимых примеров
        /// </summary>
        private const int MaxProblemsCount = 10;

        /// <summary>
        /// Перечень текстовых полей, в которых отображаются генерируемые примеры
        /// </summary>
        private List<Control> _problemsList; 
        
        /// <summary>
        /// Было создано дочернее окно
        /// </summary>
        public static bool ChildWasCreated = false;

        /// <summary>
        /// Было создано окно с заметками
        /// </summary>
        public static bool NotesWasCreated = false;

        #endregion
        
        public MainForm()
        {
            InitializeComponent();

            SubscribeOnEvents();
            CreateProblemsList();
            AddToolTips();
            LoadConfig();

            comboBoxOperations.SelectedIndex = 0;
        }

        #region Обработка событий

        /// <summary>
        /// Событие по нажатию кнопки "Удалить фильтр"
        /// </summary>
        private void DeleteSelectedFilter(object sender, EventArgs e)
        {
            if (CurrentFilterIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить выбранный фильтр?", "Подтвердите удаление фильтра", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    var arg = new FilterEventArgs();
                    arg.index = CurrentFilterIndex;
                    FilterWasDeleted?.Invoke(this, arg);

                    comboBoxFilter.Items.RemoveAt(arg.index);
                    if (arg.index > 0)
                    {
                        comboBoxFilter.SelectedIndex = arg.index - 1;
                    }
                    labelAboutFiltr.Text = "";
                }
            }
        }

        /// <summary>
        /// Была выбрана опция использования фильтров при генерации примеров
        /// </summary>
        private void UseFilerChanged(object sender, EventArgs e)
        {
            bool state = checkBoxUseFiler.Checked;
            comboBoxFilter.Visible = state;
            buttonNewFilter.Visible = state;
            buttonDeleteFilter.Visible = state;
            buttonEditFilter.Visible = state;
            labelAboutFiltr.Visible = state;

            UseFilterChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Изменилась операция, для которой генерируются примеры
        /// </summary>
        private void OperationChanged(object sender, EventArgs e)
        {
            ChangeOperation?.Invoke(this, EventArgs.Empty);
            // Если операция возведение в степень, то устанавливаем лимит
            if (OperationId == 4)
            {
                SetMaxValueN(); 
            }
            // Иначе, если лимит не сброшен, сбрасываем его
            else if (numericUpDownN.Maximum != numericUpDownM.Maximum)    
            {
                numericUpDownN.Maximum = numericUpDownM.Maximum;
            }
        }

        #endregion

        #region Основные методы

        /// <summary>
        /// Добавить новый фильтр чисел к списку уже имеющихся фильтров
        /// </summary>
        /// <param name="newFilter">Новый фильтр</param>
        public void AddNewFilter(Filter newFilter)
        {
            CurrentFilter = newFilter;
            comboBoxFilter.Items.Add(CurrentFilter.FilterName);
            FilterWasAdded?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обновить выбранный фильтр
        /// </summary>
        /// <param name="filter">Новые параметры фильтра</param>
        /// <param name="index">Индекс фильтра в общем списке фильтров</param>
        public void UpdateFilter(Filter filter, int index)
        {
            CurrentFilter = filter;
            comboBoxFilter.Items[index] = filter.FilterName;

            if (index == CurrentFilterIndex)
            {
                labelAboutFiltr.Text = filter.Description;
            }

            FilterEventArgs e = new FilterEventArgs
            {
                filter = filter,
                index = index
            };

            FilterWasUpdated?.Invoke(this, e);
        }

        /// <summary>
        /// Установить основной шрифт окна
        /// </summary>
        /// <param name="fnt">Новый шрифт элементов управления</param>
        public void ChangeFont(Font fnt)
        {
            FontSetter.SetFontWithExeptions(fnt, Controls, _problemsList);
        }

        /// <summary>
        /// Установить шрифт примеров/задач
        /// </summary>
        /// <param name="fnt">Шрифт, который должен быть установлен всем элементам, отображающим примеры</param>
        public void ChangeExamplesFont(Font fnt)
        {
            FontSetter.SetFontToControls(fnt, _problemsList);
        }

        /// <summary>
        /// Изменить количество отображаемых примеров
        /// </summary>
        /// <param name="num">Новое количество отображаемых примеров</param>
        public void ChangeExamplesCount(int num)
        {
            for (int i = 9; i > num - 1; i--)
            {
                _problemsList[i].Visible = false;
            }
            for (int i = 0; i < num; i++)
            {
                _problemsList[i].Visible = true;
            }
        }

        #endregion

        #region Вспомогательные методы
        /// <summary>
        /// Установить максимально возможное значение числа N (для ограничения возведения больших чисел в большую степень)
        /// </summary>
        private void SetMaxValueN()
        {
            if (OperationId != 4) return;
            
            if (GetM == 1)
            {
                numericUpDownN.Maximum = numericUpDownM.Maximum;
            }
            else
            {
                // Значение N меняется от 7 до 2 с увеличением значения M от 2 до 7 (7 + 2 = 9)
                numericUpDownN.Maximum = 9 - GetM;
            }
        }

        /// <summary>
        /// Подписка на события окна
        /// </summary>
        private void SubscribeOnEvents()
        {
            comboBoxOperations.SelectionChangeCommitted += OperationChanged;
            ButtonAnswers.Click += (s, e) => { ShowAnswersClick(this, EventArgs.Empty); };
            ButtonRandomize.Click += (s, e) => { GenerateClick?.Invoke(this, EventArgs.Empty); };
            numericUpDownM.ValueChanged += (s, e) => { SetMaxValueN(); };

            toolStripButtonAbout.Click += (s, e) => { CreateChildForm(ChildForm.AboutProgram); };
            toolStripButtonHow.Click += (s, e) => { CreateChildForm(ChildForm.Questions); };
            toolStripButtonOptions.Click += (s, e) => { CreateChildForm(ChildForm.Settings); };
            toolStripButtonNotes.Click += (s, e) => { CreateChildForm(ChildForm.Notes); };
            toolStripButtonVersion.Click += (s,e) => { CreateChildForm(ChildForm.Version); };

            buttonNewFilter.Click += (s, e) => { CreateFilterEditForm(false); };
            buttonDeleteFilter.Click += DeleteSelectedFilter;
            buttonEditFilter.Click += (s, e) => { CreateFilterEditForm(true); };
            comboBoxFilter.SelectionChangeCommitted += (s, e) => { FilterWasChanged?.Invoke(this, EventArgs.Empty); };
            checkBoxUseFiler.CheckedChanged += UseFilerChanged;
        }

        /// <summary>
        /// Создать список текстовых полей, которые будут содержать генерируемые примеры
        /// </summary>
        private void CreateProblemsList()
        {
            _problemsList = new List<Control>
            {
                labelNum1,
                labelNum2,
                labelNum3,
                labelNum4,
                labelNum5,
                labelNum6,
                labelNum7,
                labelNum8,
                labelNum9,
                labelNum10
            };
        }

        /// <summary>
        /// Добавить всплывающие подсказки для элементов управления
        /// </summary>
        private void AddToolTips()
        {
            toolTip1.SetToolTip(buttonNewFilter, "Добавить фильтр");
            toolTip1.SetToolTip(buttonDeleteFilter, "Удалить фильтр");
            toolTip1.SetToolTip(buttonEditFilter, "Изменить фильтр");
        }

        /// <summary>
        /// Загрузить конфигурацию приложения
        /// </summary>
        private void LoadConfig()
        {
            Settings settings = SettingsManager.LoadSettings();

            Font font = FontSetter.GetMainFont();
            ChangeFont(font);
            font = FontSetter.GetProblemsFont();
            ChangeExamplesFont(font);

            BackgroundImage = BackgroundManager.GetBackground(settings.BackgroundId);
            BackgroundImageLayout = settings.StretchBackground ? ImageLayout.Stretch : ImageLayout.Tile;

            ChangeExamplesCount(settings.ExamplesCount);
        }

        /// <summary>
        /// Создать дочернее окно
        /// </summary>
        /// <param name="formType">Тип создаваемого окна</param>
        private void CreateChildForm(ChildForm formType)
        {
            bool shouldReturn = formType == ChildForm.Notes ? NotesWasCreated : ChildWasCreated;
            if (shouldReturn) return;
            
            Form childForm;
            switch (formType)
            {
                case ChildForm.AboutProgram:
                    childForm = new AboutProgrammForm();
                    break;
                case ChildForm.Notes: 
                    childForm = new NotesForm();
                    break;
                case ChildForm.Questions:
                    childForm = new QuestionForm();
                    break;
                case ChildForm.Settings:
                    childForm = new SettingsForm(this);
                    break;
                default:
                    childForm = new VersionForm();
                    break;
            }

            childForm.Location = Location;
            childForm.Show();

            if (formType == ChildForm.Notes)
            {
                NotesWasCreated = true;
                return;
            }
            ChildWasCreated = true;
        }

        /// <summary>
        /// Создать окно создания/редактирования фильтров
        /// </summary>
        /// <param name="isEditingForm">Является ли окно окном редактирования, либо окном создания нового фильтра</param>
        private void CreateFilterEditForm(bool isEditingForm)
        {
            bool itsPossibleToCreateForm = !ChildWasCreated;
            itsPossibleToCreateForm &= isEditingForm ? CurrentFilterIndex >= 0 : true;
            if (!itsPossibleToCreateForm)
            {
                return;
            }

            var filterEditForm = new FilterEditForm(this, isEditingForm);
            filterEditForm.Location = Location;
            filterEditForm.Show();
            ChildWasCreated = true;
        }

        #endregion

        #region Реализация IMainForm

        public int OperationId => comboBoxOperations.SelectedIndex;

        public int GetM => (int)numericUpDownM.Value;

        public int GetN => (int)numericUpDownN.Value;

        public int CurrentFilterIndex => comboBoxFilter.SelectedIndex;

        public bool UseFilters => checkBoxUseFiler.Checked;

        public Filter CurrentFilter { get; set; }

        public event EventHandler ChangeOperation;
        public event EventHandler GenerateClick;
        public event EventHandler ShowAnswersClick;
        public event EventHandler FilterWasAdded;
        public event EventHandler FilterWasChanged;
        public event EventHandler UseFilterChanged;

        public event EventHandler<FilterEventArgs> FilterWasUpdated;
        public event EventHandler<FilterEventArgs> FilterWasDeleted;

        public void ChangeProblemsText(List<string> Examples)
        {
            for (int i = 0; i < MaxProblemsCount; i++)
            {
                _problemsList[i].Text = Examples[i];
            }
        }

        public void LoadFilters(List<Filter> filters)
        {
            for (int i = 0; i < filters.Count; i++)
            {
                comboBoxFilter.Items.Add(filters[i].FilterName);
            }
        }

        public void ChangeFilterDescription(string description)
        {
            labelAboutFiltr.Text = description;
        }
        #endregion
    }
}
