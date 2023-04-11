using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;


namespace MathTrainer
{
    public partial class SettingsForm : Form
    {
        
        MainForm mainForm;
        Settings settings;
        DataContractJsonSerializer jsonFormatter;

        // Шрифт приложения
        private string currentFont = "TF2 Secondary";
        private int fontSize = 12;
        // Шрифт примеров
        private string currentExampleFont = "Palatino Linotype";
        private int fontExampleSize = 12;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            // Загрузка конфигурации
            settings = new Settings();
            jsonFormatter = new DataContractJsonSerializer(typeof(Settings));
            using (FileStream fs = new FileStream("../Resource/settings.json", FileMode.Open))
            {
                settings = (Settings)jsonFormatter.ReadObject(fs);
            }
            LoadConfig();

            // Событие по смене фонового изображения
            comboBoxImages.SelectionChangeCommitted += ComboBoxImages_SelectionChangeCommitted;

            // События по смене основного шрифта приложения
            comboBoxFont.SelectionChangeCommitted += ComboBoxFont_SelectionChangeCommitted;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;

            // События по смене шрифта примеров
            comboBoxExamplesFont.SelectionChangeCommitted += ComboBoxExamplesFont_SelectionChangeCommitted;
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;

            // События по смене шрифта заметок
            comboBoxNotesFont.SelectionChangeCommitted += ComboBoxNotesFont_SelectionChangeCommitted;
            numericUpDownNotesSize.ValueChanged += NumericUpDownNotesSize_ValueChanged;

            // События по нажатию кнопок
            radioButtonNo.Click += RadioButtonNo_Click;
            radioButtonYes.Click += RadioButtonYes_Click;

            // смена выводимого количества примеров
            numericUpDown3.ValueChanged += NumericUpDown3_ValueChanged;

            // По нажатию на восстанволение по-умолчанию
            buttonEarly.Click += ButtonEarly_Click;
        }

        // Изменилось число выводимых примеров
        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            mainForm.ChangeExamplesCount((int)numericUpDown3.Value);
            settings.NumOfExamples = (int)numericUpDown3.Value;
            UpdateConfig();
        }

        // Растягивать изображение
        private void RadioButtonYes_Click(object sender, EventArgs e)
        {
            mainForm.BackgroundImageLayout = ImageLayout.Stretch;
            settings.Stretch = true;
            UpdateConfig();
        }

        // Не растягивать изображение
        private void RadioButtonNo_Click(object sender, EventArgs e)
        {
            mainForm.BackgroundImageLayout = ImageLayout.Tile;
            settings.Stretch = false;
            UpdateConfig();
        }

        // Изменился размер шрифта примеров
        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fontExampleSize = (int)numericUpDown2.Value;
            ChangeExamplesFont();
            settings.ExamplesFontSize = fontExampleSize;
            UpdateConfig();
        }

        // Изменился шрифт примеров
        private void ComboBoxExamplesFont_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentExampleFont = comboBoxExamplesFont.SelectedItem.ToString();
            ChangeExamplesFont();
            settings.CurrentExamplesFontName = currentExampleFont;
            UpdateConfig();
            settings.CurrentExamplesFont = comboBoxExamplesFont.SelectedIndex;
            UpdateConfig();
        }

        // Изменился шрифт заметок
        private void ComboBoxNotesFont_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.CurrentNotesFont = comboBoxNotesFont.SelectedIndex;
            UpdateConfig();
            settings.CurrentNotesFontName = comboBoxNotesFont.SelectedItem.ToString();
            UpdateConfig();
        }

        // Изменился размер шрифта заметок
        private void NumericUpDownNotesSize_ValueChanged(object sender, EventArgs e)
        {
            settings.NotesFontSize = (int)numericUpDownNotesSize.Value;
            UpdateConfig();
        }

        // Изменился размер основного шрифта
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fontSize = (int)numericUpDown1.Value;
            ChangeFont();
            settings.FontSize = fontSize;
            UpdateConfig();
        }

        // Изменился основной шрифт приложения
        private void ComboBoxFont_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentFont = comboBoxFont.SelectedItem.ToString();
            ChangeFont();
            settings.CurrentFontName = currentFont;
            UpdateConfig();
            settings.CurrentFont = comboBoxFont.SelectedIndex;
            UpdateConfig();
        }

        // Нажали кнопку "Восстановить по-умолчанию"
        private void ButtonEarly_Click(object sender, EventArgs e)
        {
            // Восстановление основного шрифта
            comboBoxFont.SelectedIndex = 7;
            currentFont = comboBoxFont.SelectedItem.ToString();
            settings.CurrentFontName = currentFont;
            settings.CurrentFont = 7;

            numericUpDown1.Value = 12;
            fontSize = 12;
            settings.FontSize = 12;
            ChangeFont();

            // Восстановление шрифта примеров
            comboBoxExamplesFont.SelectedIndex = 6;
            currentExampleFont = comboBoxExamplesFont.SelectedItem.ToString();
            settings.CurrentExamplesFontName = currentExampleFont;
            settings.CurrentExamplesFont = 6;

            numericUpDown2.Value = 12;
            fontExampleSize = 12;
            settings.ExamplesFontSize = 12;
            ChangeExamplesFont();

            // Восстановление шрифта заметок
            comboBoxNotesFont.SelectedIndex = 6;
            settings.CurrentNotesFont = 6;
            settings.CurrentNotesFontName = comboBoxNotesFont.SelectedItem.ToString();

            numericUpDownNotesSize.Value = 12;
            settings.NotesFontSize = 12;

            // Восстановление выводимого числа примеров
            numericUpDown3.Value = 10;
            mainForm.ChangeExamplesCount((int)numericUpDown3.Value);
            settings.NumOfExamples = 10;

            // Восстановление фона основного окна
            comboBoxImages.SelectedIndex = 0;
            settings.BackgroundNumber = 0;
            string imageName = "../Resource/Backgrounds/" + settings.BackgroundNumber + ".jpg";
            pictureBox1.BackgroundImage = Image.FromFile(imageName);
            mainForm.BackgroundImage = Image.FromFile(imageName);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            radioButtonNo.Checked = true;
            mainForm.BackgroundImageLayout = ImageLayout.Tile;
            settings.Stretch = false;

            // Запись в файл конфигурации
            UpdateConfig();
        }

        // Изменилось фоновое изображение основного окна
        private void ComboBoxImages_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.BackgroundNumber = comboBoxImages.SelectedIndex;

            string imageName = "../Resource/Backgrounds/" + settings.BackgroundNumber + ".jpg";
            pictureBox1.BackgroundImage = Image.FromFile(imageName);
            mainForm.BackgroundImage = Image.FromFile(imageName);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            UpdateConfig();
        }

        // Изменить основной шрифт приложения
        private void ChangeFont()
        {
            Font _currentFont = new Font(currentFont, fontSize);

            // смена шрифта в окне настроек
            labelNumOfExamples.Font = _currentFont;
            numericUpDown3.Font = _currentFont;

            labelFont.Font = _currentFont;
            comboBoxFont.Font = _currentFont;
            labelSize.Font = _currentFont;
            numericUpDown1.Font = _currentFont;

            labelExamplesFont.Font = _currentFont;
            comboBoxExamplesFont.Font = _currentFont;
            labelExamplaseSize.Font = _currentFont;
            numericUpDown2.Font = _currentFont;

            labelNotesFont.Font = _currentFont;
            comboBoxNotesFont.Font = _currentFont;
            labelNotesSize.Font = _currentFont;
            numericUpDownNotesSize.Font = _currentFont;

            buttonEarly.Font = _currentFont;

            labelBackGround.Font = _currentFont;
            comboBoxImages.Font = _currentFont;
            labelSizeImage.Font = _currentFont;
            radioButtonYes.Font = _currentFont;
            radioButtonNo.Font = _currentFont;

            // Смена фона основного окна
            mainForm.ChangeFont(_currentFont);
        }

        // Изменить шрифт примеров
        private void ChangeExamplesFont()
        {
            Font _currentFont = new Font(currentExampleFont, fontExampleSize);
            mainForm.ChangeExamplesFont(_currentFont);
        }

        // Загрузка файла конфигурации
        private void LoadConfig()
        {
            //Значения шрифтов
            comboBoxFont.SelectedIndex = settings.CurrentFont;
            comboBoxExamplesFont.SelectedIndex = settings.CurrentExamplesFont;
            comboBoxNotesFont.SelectedIndex = settings.CurrentNotesFont;
            currentFont = comboBoxFont.SelectedItem.ToString();
            currentExampleFont = comboBoxExamplesFont.SelectedItem.ToString();

            // Размеры шрифтов
            numericUpDown1.Value = settings.FontSize;
            numericUpDown2.Value = settings.ExamplesFontSize;
            numericUpDownNotesSize.Value = settings.NotesFontSize;
            fontSize = (int)numericUpDown1.Value;
            fontExampleSize = (int)numericUpDown2.Value;

            // Обновление шрифтов
            ChangeFont();
            ChangeExamplesFont();

            // Число примеров
            numericUpDown3.Value = settings.NumOfExamples;
            mainForm.ChangeExamplesCount((int)numericUpDown3.Value);

            // Выбираем элемент в списке фонов 
            comboBoxImages.SelectedIndex = settings.BackgroundNumber;
            string imageName = "../Resource/Backgrounds/" + settings.BackgroundNumber + ".jpg";
            pictureBox1.BackgroundImage = Image.FromFile(imageName);
            mainForm.BackgroundImage = Image.FromFile(imageName);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // нажатия кнопок
            radioButtonYes.Checked = settings.Stretch;
            radioButtonNo.Checked = !settings.Stretch;
            if (!settings.Stretch) mainForm.BackgroundImageLayout = ImageLayout.Tile;
            else mainForm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Обновление файла конфигурации
        private void UpdateConfig()
        {
            using (FileStream fs = new FileStream("../Resource/settings.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, settings);
            }
        }

    }
}
