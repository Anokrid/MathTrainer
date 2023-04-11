using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MathTrainer
{

    public partial class FilterEditForm : Form
    {
        List<ComboBox> ComboBoxesA;
        List<ComboBox> ComboBoxesB;
        List<NumericUpDown> NumericSumm;
        MainForm mainForm;

        bool isEdit;
        public int FilterIndex;
        
        int ClearNumber = 0;    // Отвечает за то, что будет очищено

        public FilterEditForm(MainForm mainForm, bool isEdit)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.isEdit = isEdit;

            #region Заполнение массивов комбобоксов
            ComboBoxesA = new List<ComboBox>();
            ComboBoxesA.Add(comboBoxA1);
            ComboBoxesA.Add(comboBoxA2);
            ComboBoxesA.Add(comboBoxA3);
            ComboBoxesA.Add(comboBoxA4);
            ComboBoxesA.Add(comboBoxA5);
            ComboBoxesA.Add(comboBoxA6);
            ComboBoxesA.Add(comboBoxA7);

            ComboBoxesB = new List<ComboBox>();
            ComboBoxesB.Add(comboBoxB1);
            ComboBoxesB.Add(comboBoxB2);
            ComboBoxesB.Add(comboBoxB3);
            ComboBoxesB.Add(comboBoxB4);
            ComboBoxesB.Add(comboBoxB5);
            ComboBoxesB.Add(comboBoxB6);
            ComboBoxesB.Add(comboBoxB7);

            for (int i=0; i<ComboBoxesA.Count; i++)
            {
                ComboBoxesA[i].SelectedIndex = 0;
                ComboBoxesB[i].SelectedIndex = 0;
            }
            #endregion

            #region Заполнение массивов числовых полей
            NumericSumm = new List<NumericUpDown>();
            NumericSumm.Add(numericUpDownS1);
            NumericSumm.Add(numericUpDownS2);
            NumericSumm.Add(numericUpDownS3);
            NumericSumm.Add(numericUpDownS4);
            NumericSumm.Add(numericUpDownS5);
            #endregion

            buttonClearFilters.Click += ButtonClearFilters_Click;
            buttonClearText.Click += ButtonClearText_Click;
            buttonClearSumm.Click += ButtonClearSumm_Click;
            buttonClearAll.Click += ButtonClearAll_Click;
            buttonYes.Click += ButtonYes_Click;
            buttonNo.Click += ButtonNo_Click;
            buttonSave.Click += ButtonSave_Click;
        }

        // Нажатие кнопки сохранить
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SetNewFilter();
            Close();
        }

        // Нажатие кнопки Нет
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            ShowYesNoButtons(false);
        }

        // Нажатие кнопки Да
        private void ButtonYes_Click(object sender, EventArgs e)
        {
            switch (ClearNumber)
            {
                case 0:
                    ClearFilters();
                    break;
                case 1:
                    ClearText();
                    break;
                case 2:
                    ClearSumm();
                    break;
                case 3:
                    ClearFilters();
                    ClearText();
                    ClearSumm();
                    break;
            }

            ShowYesNoButtons(false);
        }

        // Нажатие кнопки очистить всё
        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            ClearNumber = 3;
            ShowYesNoButtons(true);
        }

        // Нажатие кнопки "Очистить суммы"
        private void ButtonClearSumm_Click(object sender, EventArgs e)
        {
            ClearNumber = 2;
            ShowYesNoButtons(true);
        }

        // Нажатие на кнопку "Очистить текст"
        private void ButtonClearText_Click(object sender, EventArgs e)
        {
            ClearNumber = 1;
            ShowYesNoButtons(true);
        }

        // Нажатие на кнопку "Сбросить фильтры"
        private void ButtonClearFilters_Click(object sender, EventArgs e)
        {
            ClearNumber = 0;
            ShowYesNoButtons(true);
        }

        // Показывать кнопки ДА/нет
        private void ShowYesNoButtons(bool flag)
        {
            buttonYes.Visible = flag;
            buttonNo.Visible = flag;
        }

        // Функция очистки фильтров
        private void ClearFilters()
        {
            for (int i = 0; i < ComboBoxesA.Count; i++)
            {
                ComboBoxesA[i].SelectedIndex = 0;
                ComboBoxesB[i].SelectedIndex = 0;
            }
        }

        // Функция очистки текста
        private void ClearText()
        {
            textBoxFilterName.Text = "";
            textBoxDescrition.Text = "";
        }

        // Функция очистки сумм
        private void ClearSumm()
        {
            for (int i = 0; i < Filter.SumsCount; i++)
            {
                NumericSumm[i].Value = 0;
            }
        }

        // Сбор данных с элементов управления и запись в Filter
        public void SetNewFilter()
        {
            Filter newFilter = new Filter();

            // Название фильтра
            newFilter.FilterName = textBoxFilterName.Text;

            // Описание фильтра
            newFilter.Description = textBoxDescrition.Text;

            // Значения сумм
            for (int i=0; i<Filter.SumsCount; i++)
            {
                newFilter.Sum[i] = (int)NumericSumm[i].Value;
            }

            // Значения фильтров
            for (int i=0; i<Filter.Dimension; i++)
            {
                newFilter.FilterA[i] = ComboBoxesA[i].SelectedItem.ToString();
                newFilter.FilterB[i] = ComboBoxesB[i].SelectedItem.ToString();
            }

            mainForm.specialFilter = newFilter;
            if (!isEdit) mainForm.AddFilters();
            else mainForm.UpdateFilter(newFilter, FilterIndex);
        }

        // Загрузка данных с фильтра в элементы управления
        public void LoadFilter(Filter filter)
        {
            // Название фильтра
            textBoxFilterName.Text = filter.FilterName;

            // Описание фильтра
            textBoxDescrition.Text = filter.Description;

            // Значения сумм
            for (int i = 0; i < Filter.SumsCount; i++)
            {
                NumericSumm[i].Value = filter.Sum[i];
            }

            // Значения фильтров
            for (int i = 0; i < Filter.Dimension; i++)
            {
                ComboBoxesA[i].SelectedItem = filter.FilterA[i];
                ComboBoxesB[i].SelectedItem = filter.FilterB[i];
            }
        }

        // Смена шрифта
        public void ChangeFont(Font font)
        {
            textBoxFilterName.Font = font;

            labelNum1.Font = font;
            labelNum2.Font = font;

            labelS1.Font = font;
            labelS2.Font = font;
            labelS3.Font = font;
            labelS4.Font = font;
            labelS5.Font = font;

            numericUpDownS1.Font = font;
            numericUpDownS2.Font = font;
            numericUpDownS3.Font = font;
            numericUpDownS4.Font = font;
            numericUpDownS5.Font = font;

            comboBoxA1.Font = font;
            comboBoxA2.Font = font;
            comboBoxA3.Font = font;
            comboBoxA4.Font = font;
            comboBoxA5.Font = font;
            comboBoxA6.Font = font;
            comboBoxA7.Font = font;

            comboBoxB1.Font = font;
            comboBoxB2.Font = font;
            comboBoxB3.Font = font;
            comboBoxB4.Font = font;
            comboBoxB5.Font = font;
            comboBoxB6.Font = font;
            comboBoxB7.Font = font;

            textBoxDescrition.Font = font;

            buttonClearFilters.Font = font;
            buttonClearText.Font = font;
            buttonClearSumm.Font = font;
            buttonClearAll.Font = font;

            buttonSave.Font = font;

            buttonYes.Font = font;
            buttonNo.Font = font;
        }
    }
}
