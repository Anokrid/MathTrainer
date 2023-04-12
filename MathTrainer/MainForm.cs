using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MathTrainer
{
    public partial class MainForm : Form, IMainForm
    {
        List<Control> ExamplesArea;
        public static bool ChildWasCreated = false;
        public static bool NotesWasCreated = false;
        Font globalFont;
        public Filter specialFilter;

        // Инициализация
        public MainForm()
        {
            InitializeComponent();

            #region Подписка на события
            comboBox1.SelectionChangeCommitted += new EventHandler(comboBox1_Change);

            ButtonAnswers.Click += new EventHandler(ButtonAnswers_Click);

            ButtonRandomize.Click += new EventHandler(ButtonRandomize_Click);

            numericUpDownM.ValueChanged += new EventHandler(NumberMChanged);

            toolStripButtonAbout.Click += ToolStripButtonAbout_Click;
            toolStripButtonHow.Click += ToolStripButtonHow_Click;
            toolStripButtonOptions.Click += ToolStripButtonOptions_Click;
            toolStripButtonNotes.Click += ButtonNotes_Click;
            toolStripButtonVersion.Click += ToolStripButtonVersion_Click;

            checkBoxUseFiler.CheckedChanged += CheckBoxUseFiler_CheckedChanged;

            buttonNewFilter.Click += ButtonNewFilter_Click;
            buttonDeleteFilter.Click += ButtonDeleteFilter_Click;
            buttonEditFilter.Click += ButtonEditFilter_Click;
            buttonConfirm.Click += ButtonConfirm_Click;

            comboBoxFilter.SelectionChangeCommitted += ComboBoxFilter_SelectionChangeCommitted;

            checkBoxUseFiler.CheckedChanged += CheckBoxUseFiler_CheckedChanged1;
            #endregion

            #region Создание массива с текстами примеров
            ExamplesArea = new List<Control>();
            ExamplesArea.Add(labelNum1);
            ExamplesArea.Add(labelNum2);
            ExamplesArea.Add(labelNum3);
            ExamplesArea.Add(labelNum4);
            ExamplesArea.Add(labelNum5);
            ExamplesArea.Add(labelNum6);
            ExamplesArea.Add(labelNum7);
            ExamplesArea.Add(labelNum8);
            ExamplesArea.Add(labelNum9);
            ExamplesArea.Add(labelNum10);
            #endregion

            comboBox1.SelectedIndex = 0;

            toolTip1.SetToolTip(buttonNewFilter, "Добавить фильтр");
            toolTip1.SetToolTip(buttonDeleteFilter, "Удалить фильтр"); 
            toolTip1.SetToolTip(buttonEditFilter, "Изменить фильтр");

            LoadConfig();
        }

        #region Обработка событий
        // Событие по нажатию кнопки "Версия" в верхнем меню
        private void ToolStripButtonVersion_Click(object sender, EventArgs e)
        {
            if (!ChildWasCreated)
            {
                VersionForm versionForm = new VersionForm();
                versionForm.Location = Location;
                versionForm.ChangeFont(globalFont);
                versionForm.Show();
                ChildWasCreated = true;
            }
        }

        // Событие по нажатию кнопки подтверждения удаления выбранного фильтра
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            FilterEventArgs arg = new FilterEventArgs();
            arg.index = comboBoxFilter.SelectedIndex;
            if (FilterWasDeleted!=null) FilterWasDeleted(this, arg);

            comboBoxFilter.Items.RemoveAt(arg.index);
            if (arg.index>0) comboBoxFilter.SelectedIndex = arg.index-1;
            labelAboutFiltr.Text = "";

            buttonConfirm.Visible = false;
        }

        // Событие по нажатию кнопки удалить фильтр
        private void ButtonDeleteFilter_Click(object sender, EventArgs e)
        {
            if ((!buttonConfirm.Visible) && (comboBoxFilter.SelectedIndex >= 0))
            {
                buttonConfirm.Visible = true;
            }
        }

        // Событие по смене использвания/отключения фильтров
        private void CheckBoxUseFiler_CheckedChanged1(object sender, EventArgs e)
        {
            if (UseFilterChanged!=null) UseFilterChanged(this, EventArgs.Empty);
        }

        // Событие по смене выбранного фильтра
        private void ComboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (buttonConfirm.Visible)
            {
                buttonConfirm.Visible = false;
            }

            FilterWasChanged?.Invoke(this, EventArgs.Empty);
        }

        // Событие по нажатию кнопки "Добавить фильтр"
        private void ButtonNewFilter_Click(object sender, EventArgs e)
        {
            if (!ChildWasCreated)
            {
                FilterEditForm filterEditForm = new FilterEditForm(this, false);
                filterEditForm.Location = Location;
                filterEditForm.ChangeFont(globalFont);
                filterEditForm.Show();
                ChildWasCreated = true;
            }
        }

        // Событие по нажатию кнопки "Изменить фильтр"
        private void ButtonEditFilter_Click(object sender, EventArgs e)
        {
            if ((!ChildWasCreated) && (comboBoxFilter.SelectedIndex >= 0))
            {
                FilterEditForm filterEditForm = new FilterEditForm(this, true);
                filterEditForm.Location = Location;
                filterEditForm.Text = "Редактирование фильтра";
                filterEditForm.FilterIndex = comboBoxFilter.SelectedIndex;
                filterEditForm.Icon = new Icon("../Resource/Icons/Edit.ico");
                filterEditForm.LoadFilter(CurrentFilter);
                filterEditForm.ChangeFont(globalFont);
                filterEditForm.Show();
                ChildWasCreated = true;
            }
        }

        // Событие по галочке "Специальные фильтры"
        private void CheckBoxUseFiler_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFilter.Visible = checkBoxUseFiler.Checked;
            buttonNewFilter.Visible = checkBoxUseFiler.Checked;
            buttonDeleteFilter.Visible = checkBoxUseFiler.Checked;
            buttonEditFilter.Visible = checkBoxUseFiler.Checked;
            labelAboutFiltr.Visible = checkBoxUseFiler.Checked;
        }

        // Событие по нажатию кнопки "Заметки"
        private void ButtonNotes_Click(object sender, EventArgs e)
        {
            if (!NotesWasCreated)
            {
                NotesForm notesForm = new NotesForm();
                notesForm.Location = Location;
                notesForm.Show();
                NotesWasCreated = true;
            }
        }

        // Событие по нажатию кнопки "Настройки"
        private void ToolStripButtonOptions_Click(object sender, EventArgs e)
        {
            if (!ChildWasCreated)
            {
                SettingsForm settingsForm = new SettingsForm(this);
                settingsForm.Location = this.Location;
                settingsForm.Show();
                ChildWasCreated = true;
            }
        }

        // Событие по нажатие кнопки "Как работать?"
        private void ToolStripButtonHow_Click(object sender, EventArgs e)
        {
            if (!ChildWasCreated)
            {
                QuestionForm questionForm = new QuestionForm();
                questionForm.Location = Location;
                questionForm.Show();
                questionForm.ChangeFont(globalFont);
                ChildWasCreated = true;
            }
        }

        // Событие по нажатию кнопки "Про приложение"
        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            if (!ChildWasCreated)
            {
                AboutProgrammForm aboutProgrammForm = new AboutProgrammForm();
                aboutProgrammForm.Location = Location;
                aboutProgrammForm.Show();
                aboutProgrammForm.ChangeFont(globalFont);
                ChildWasCreated = true;
            }
        }

        // Событие по нажатию кнопки "Сгенерировать примеры"
        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            GenerateClick(this, EventArgs.Empty);
        }

        // Событие по нажатию кнопки "Показать ответы"
        private void ButtonAnswers_Click(object sender, EventArgs e)
        {
            ShowAnswersClick(this, EventArgs.Empty);
        }

        // Событие по смене типа примера
        private void comboBox1_Change(object sender, EventArgs e)
        {
            if (ChangeOperation != null) ChangeOperation(this, EventArgs.Empty);
            // Если операция возведение в степень, то устанавливаем лимит
            if (OperationId == 4)
            {
                SetMaxValueN(); 
            }
            // Иначе, если лимит не сброшен, сбрасываем его
            else if (numericUpDownN.Maximum !=7)    
            {
                numericUpDownN.Maximum = 7;
                numericUpDownM.Maximum = 7;
            }
        }

        // Событие по смене значения числа "М"
        private void NumberMChanged(object sender, EventArgs e)
        {
            if (OperationId == 4) SetMaxValueN();
        }
        #endregion

        #region Вспомогательные методы
        /// <summary>
        /// Установить максимально возможное значение числа N (для ограничения возведения больших чисел в большую степень)
        /// </summary>
        private void SetMaxValueN()
        {
            if (GetM == 1)
            {
                // Значение по умолчанию
                numericUpDownN.Maximum = 7;
            }
            else
            {
                // Значение N меняется от 7 до 2 с увеличением значения M от 2 до 7
                numericUpDownN.Maximum = 9 - GetM;
            }
        }

        public void ChangeFont(Font fnt)
        {
            LabelM.Font = fnt;
            LabelN.Font = fnt;
            numericUpDownM.Font = fnt;
            numericUpDownN.Font = fnt;
            LabelFunction.Font = fnt;
            comboBox1.Font = fnt;
            ButtonRandomize.Font = fnt;
            ButtonAnswers.Font = fnt;
            checkBoxUseFiler.Font = fnt;
            comboBoxFilter.Font = fnt;
            buttonConfirm.Font = fnt;
            labelAboutFiltr.Font = fnt;

            globalFont = fnt;
        }

        public void ChangeExamplesFont(Font fnt)
        {
            for (int i = 0; i < 10; i++)
            {
                ExamplesArea[i].Font = fnt;
            }
        }

        /// <summary>
        /// Изменить количество отображаемых примеров
        /// </summary>
        /// <param name="num">Новое количество отображаемых примеров</param>
        public void ChangeExamplesCount(int num)
        {
            for (int i = 9; i > num - 1; i--)
            {
                ExamplesArea[i].Visible = false;
            }
            for (int i = 0; i < num; i++)
            {
                ExamplesArea[i].Visible = true;
            }
        }

        private void LoadConfig()
        {
            Settings settings = SettingsManager.LoadSettings();

            // Смена шрифта
            string currentFont = settings.MainFontName;
            Font font = new Font(currentFont, settings.MainFontSize);
            globalFont = font;
            ChangeFont(font);

            // Смена шрифта примеров
            currentFont = settings.ExamplesFontName;
            font = new Font(currentFont, settings.ExamplesFontSize);
            ChangeExamplesFont(font);

            // Смена бэкграунда
            string imageName = "../Resource/Backgrounds/" + settings.BackgroundId + ".jpg";
            BackgroundImage = Image.FromFile(imageName);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            if (settings.StretchBackground) BackgroundImageLayout = ImageLayout.Stretch;
            else BackgroundImageLayout = ImageLayout.Tile;

            // Загрузка числа примеров
            ChangeExamplesCount(settings.ExamplesCount);
        }

        /// <summary>
        /// Добавить новый фильтр чисел к списку уже имеющихся фильтров
        /// </summary>
        public void AddFilters()
        {
            comboBoxFilter.Items.Add(specialFilter.FilterName);
            FilterWasAdded?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateFilter(Filter filter, int index)
        {
            comboBoxFilter.Items[index] = filter.FilterName;

            if (index == comboBoxFilter.SelectedIndex)
            {
                labelAboutFiltr.Text = filter.Description;
            }

            FilterEventArgs e = new FilterEventArgs();
            e.filter = filter;
            e.index = index;

            FilterWasUpdated?.Invoke(this, e);
        } 
        #endregion

        #region Реализация IMainForm

        public int OperationId => comboBox1.SelectedIndex;

        public int GetM => (int)numericUpDownM.Value;

        public int GetN => (int)numericUpDownN.Value;

        public Filter CurrentFilter => specialFilter;

        public int CurrentFilterIndex => comboBoxFilter.SelectedIndex;

        public bool UseFilters => checkBoxUseFiler.Checked;

        Filter IMainForm.CurrentFilter
        {
            get => specialFilter;
            set => specialFilter = value;
        }

        public event EventHandler ChangeOperation;
        public event EventHandler GenerateClick;
        public event EventHandler ShowAnswersClick;
        public event EventHandler FilterWasAdded;
        public event EventHandler FilterWasChanged;
        public event EventHandler UseFilterChanged;

        public event EventHandler<FilterEventArgs> FilterWasUpdated;
        public event EventHandler<FilterEventArgs> FilterWasDeleted;

        public void ChangeText(List<string> Examples)
        {
            for (int i=0; i<10; i++)
            {
                ExamplesArea[i].Text = Examples[i];
            }
        }

        public void LoadFilters(List<Filter> filters)
        {
            for (int i=0; i< filters.Count; i++)
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
