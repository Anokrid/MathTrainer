using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно создания и редактирования фильтров, применяемых к числам А и В, участвующим в примерах
    /// </summary>
    public partial class FilterEditForm : Form
    {
        #region Закрытые поля
        
        /// <summary>
        /// Список комбобоксов, отвечающих за фильтр, применяемый к конкретной цифре числа А
        /// </summary>
        private List<ComboBox> _comboBoxesA;

        /// <summary>
        /// Список комбобоксов, отвечающих за фильтр, применяемый к конкретной цифре числа В
        /// </summary>
        private List<ComboBox> _comboBoxesB;

        /// <summary>
        /// Список контролов, отвечающих за задание сумм, которые должны образовывать цифры чисел А и В, помеченные фильтрами S1-S5
        /// </summary>
        List<NumericUpDown> NumericSums;

        /// <summary>
        /// Основное окно приложения (оно же родительское окно)
        /// </summary>
        private MainForm _mainForm;

        /// <summary>
        /// Является ли данное окно окном редактирования, либо же это окно создания нового фильтра
        /// </summary>
        private bool _isEditForm;

        /// <summary>
        /// Индекс редактируемого фильтра в списке всех фильтров
        /// </summary>
        public int _filterIndex;

        /// <summary>
        /// Метод, отвечающий за очистку определённых контролов формы
        /// </summary>
        ClearOperation clearDataOperation;

        /// <summary>
        /// Операция по очистке определённой информации в окне
        /// </summary>
        private delegate void ClearOperation();
        #endregion

        /// <summary>
        /// Конструктор формы, позволяющей создавать и редактировать фильтры, применяемые к числам А и В, участвующим в генерируемых примерах
        /// </summary>
        /// <param name="mainForm">Основное окно приложения</param>
        /// <param name="isEdit">Является ли данное окно окном редактирования, либо окном создания фильтра</param>
        public FilterEditForm(MainForm mainForm, bool isEdit)
        {
            _mainForm = mainForm;
            _isEditForm = isEdit;

            InitializeComponent();
            FontSetter.SetMainFont(Controls);

            FillComboBoxesArrays();
            FillNumericUpDownArray();
            SubscribeOnEvents();
            CheckIfItsEditingForm();
        }

        #region Обработка событий

        /// <summary>
        /// Была нажата кнопка сохранения нового фильтра / изменения старого фильтра
        /// </summary>
        private void ButtonSaveClick(object sender, EventArgs e)
        {
            SetNewFilter();
            Close();
        }

        /// <summary>
        /// Была нажата кнопка отмены очистки контролов
        /// </summary>
        private void ButtonNoClick(object sender, EventArgs e)
        {
            ShowYesNoButtons(false);
        }

        /// <summary>
        /// Была нажата кнопка подтверждения очистки определённых контролов
        /// </summary>
        private void ButtonYesClick(object sender, EventArgs e)
        {
            clearDataOperation();
            ShowYesNoButtons(false);
        }

        /// <summary>
        /// Была нажата кнопка "Очистить всё"
        /// </summary>
        private void ButtonClearAllClick(object sender, EventArgs e)
        {
            clearDataOperation = () =>
            {
                ClearFilters();
                ClearText();
                ClearSum();
            };

            ShowYesNoButtons(true);
        }

        /// <summary>
        /// Была нажата кнопка "Очистить суммы"
        /// </summary>
        private void ButtonClearSumClick(object sender, EventArgs e)
        {
            clearDataOperation = ClearSum;
            ShowYesNoButtons(true);
        }

        /// <summary>
        /// Была нажата кнопка "Очистить текст"
        /// </summary>
        private void ButtonClearTextClick(object sender, EventArgs e)
        {
            clearDataOperation = ClearText;
            ShowYesNoButtons(true);
        }

        /// <summary>
        /// Была нажата кнопка "Сбросить фильтры"
        /// </summary>
        private void ButtonClearFiltersClick(object sender, EventArgs e)
        {
            clearDataOperation = ClearFilters;
            ShowYesNoButtons(true);
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Заполнить массивы комбобоксов, содержащих текущие фильтры, применяемые к конкретным цифрам чисел А и В
        /// </summary>
        private void FillComboBoxesArrays()
        {
            _comboBoxesA = new List<ComboBox>
            {
                comboBoxA1,
                comboBoxA2,
                comboBoxA3,
                comboBoxA4,
                comboBoxA5,
                comboBoxA6,
                comboBoxA7
            };

            _comboBoxesB = new List<ComboBox>
            {
                comboBoxB1,
                comboBoxB2,
                comboBoxB3,
                comboBoxB4,
                comboBoxB5,
                comboBoxB6,
                comboBoxB7
            };

            for (int i = 0; i < _comboBoxesA.Count; i++)
            {
                _comboBoxesA[i].SelectedIndex = 0;
                _comboBoxesB[i].SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Заполнить массив контролов, задающих суммы определённых цифр
        /// </summary>
        private void FillNumericUpDownArray()
        {
            NumericSums = new List<NumericUpDown>
            {
                numericUpDownS1,
                numericUpDownS2,
                numericUpDownS3,
                numericUpDownS4,
                numericUpDownS5
            };
        }

        /// <summary>
        /// Проверить, не является ли окно окном редактирования суже созданного фильтра, и если так, то выполнить определённые действия
        /// </summary>
        private void CheckIfItsEditingForm()
        {
            if (_isEditForm)
            {
                Text = "Редактирование фильтра";
                Icon = new Icon("../Resource/Icons/Edit.ico");
                _filterIndex = _mainForm.CurrentFilterIndex;
                LoadFilterData(_mainForm.CurrentFilter);
            }
        }

        /// <summary>
        /// Подписаться на события формы
        /// </summary>
        private void SubscribeOnEvents()
        {
            buttonClearFilters.Click += ButtonClearFiltersClick;
            buttonClearText.Click += ButtonClearTextClick;
            buttonClearSumm.Click += ButtonClearSumClick;
            buttonClearAll.Click += ButtonClearAllClick;
            buttonYes.Click += ButtonYesClick;
            buttonNo.Click += ButtonNoClick;
            buttonSave.Click += ButtonSaveClick;
        }

        /// <summary>
        /// Показывать кнопки ДА/НЕТ
        /// </summary>
        /// <param name="flag">Должны ли отображаться кнопки подтверждения очистки определённых контролов</param>
        private void ShowYesNoButtons(bool flag)
        {
            buttonYes.Visible = flag;
            buttonNo.Visible = flag;
        }

        /// <summary>
        /// Очистить все фильтры, применяемые к цифрам
        /// </summary>
        private void ClearFilters()
        {
            for (int i = 0; i < _comboBoxesA.Count; i++)
            {
                _comboBoxesA[i].SelectedIndex = 0;
                _comboBoxesB[i].SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Очистить весь текст (название и описание фильтра)
        /// </summary>
        private void ClearText()
        {
            textBoxFilterName.Text = "";
            textBoxDescrition.Text = "";
        }

        /// <summary>
        /// Очистить суммы
        /// </summary>
        private void ClearSum()
        {
            for (int i = 0; i < Filter.SumsCount; i++)
            {
                NumericSums[i].Value = 0;
            }
        }

        /// <summary>
        /// Собрать данные об отредактированном/созданном фильтре и передать в основное окно программы
        /// </summary>
        private void SetNewFilter()
        {
            Filter newFilter = new Filter
            {
                FilterName = textBoxFilterName.Text,
                Description = textBoxDescrition.Text
            };

            for (int i = 0; i < Filter.SumsCount; i++)
            {
                newFilter.Sum[i] = (int)NumericSums[i].Value;
            }
            for (int i = 0; i < Filter.Dimension; i++)
            {
                newFilter.FilterA[i] = _comboBoxesA[i].SelectedItem.ToString();
                newFilter.FilterB[i] = _comboBoxesB[i].SelectedItem.ToString();
            }

            if (_isEditForm)
            {
                _mainForm.UpdateFilter(newFilter, _filterIndex);
            }
            else
            {
                _mainForm.AddNewFilter(newFilter);
            }
        }

        /// <summary>
        /// Заполнение элементов управления окна данными о редактируемом фильтре
        /// </summary>
        /// <param name="filter">Редактируемый фильтр</param>
        private void LoadFilterData(Filter filter)
        {
            textBoxFilterName.Text = filter.FilterName;
            textBoxDescrition.Text = filter.Description;

            for (int i = 0; i < Filter.SumsCount; i++)
            {
                NumericSums[i].Value = filter.Sum[i];
            }
            for (int i = 0; i < Filter.Dimension; i++)
            {
                _comboBoxesA[i].SelectedItem = filter.FilterA[i];
                _comboBoxesB[i].SelectedItem = filter.FilterB[i];
            }
        } 
        #endregion
    }
}
