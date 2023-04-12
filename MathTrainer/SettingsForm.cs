using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, в котором изменяются косметические настройки приложения
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Основное окно приложения
        /// </summary>
        private MainForm _mainForm;
        
        /// <summary>
        /// Текущие настройки приложения
        /// </summary>
        private Settings _settings;

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            LoadSettings();
            ApplySettings();

            numericUpDownExamples.ValueChanged += ProblemsCountChanged;

            comboBoxFont.SelectionChangeCommitted += MainFontChanged;
            numericUpDownMainFont.ValueChanged += MainFontSizeChanged;
            comboBoxExamplesFont.SelectionChangeCommitted += ExamplesFontChanged;
            numericUpDownExamplesFont.ValueChanged += ExamplesFontSizeChanged;
            comboBoxNotesFont.SelectionChangeCommitted += NotesFontChanged;
            numericUpDownNotesFont.ValueChanged += NotesFontSizeChanged;

            comboBoxImages.SelectionChangeCommitted += BackrgoundImageChanged;
            radioButtonNo.Click += DontStretchBackground;
            radioButtonYes.Click += StretchBackground;

            buttonRestore.Click += RestoreDefaultSettings;
            buttonSave.Click += SaveSettings;
        }

        #region Обработка событий

        /// <summary>
        /// Изменилось количество выводимых примеров
        /// </summary>
        private void ProblemsCountChanged(object sender, EventArgs e)
        {
            int newProblemsCount = (int)numericUpDownExamples.Value;
            _mainForm.ChangeExamplesCount(newProblemsCount);
            _settings.ExamplesCount = newProblemsCount;
        }

        /// <summary>
        /// Растягивать фоновое изображение
        /// </summary>
        private void StretchBackground(object sender, EventArgs e)
        {
            _mainForm.BackgroundImageLayout = ImageLayout.Stretch;
            _settings.StretchBackground = true;
        }

        /// <summary>
        /// Не растягивать фоновое изображение
        /// </summary>
        private void DontStretchBackground(object sender, EventArgs e)
        {
            _mainForm.BackgroundImageLayout = ImageLayout.Tile;
            _settings.StretchBackground = false;
        }

        /// <summary>
        /// Изменился размер шрифта примеров
        /// </summary>
        private void ExamplesFontSizeChanged(object sender, EventArgs e)
        {
            _settings.ExamplesFontSize = (int)numericUpDownExamplesFont.Value;
            UpdateExamplesFont();
        }

        /// <summary>
        /// Изменился шрифт примеров
        /// </summary>
        private void ExamplesFontChanged(object sender, EventArgs e)
        {
            _settings.ExamplesFontName = comboBoxExamplesFont.SelectedItem.ToString();
            UpdateExamplesFont();
        }

        /// <summary>
        /// Изменился шрифт заметок
        /// </summary>
        private void NotesFontChanged(object sender, EventArgs e)
        {
            _settings.NotesFontName = comboBoxNotesFont.SelectedItem.ToString();
        }

        /// <summary>
        /// Изменился размер шрифта заметок
        /// </summary>
        private void NotesFontSizeChanged(object sender, EventArgs e)
        {
            _settings.NotesFontSize = (int)numericUpDownNotesFont.Value;
        }

        /// <summary>
        /// Изменился размер основного шрифта
        /// </summary>
        private void MainFontSizeChanged(object sender, EventArgs e)
        {
            _settings.MainFontSize = (int)numericUpDownMainFont.Value;
            UpdateMainFont();
        }

        /// <summary>
        /// Изменился основной шрифт приложения
        /// </summary>
        private void MainFontChanged(object sender, EventArgs e)
        {
            _settings.MainFontName = comboBoxFont.SelectedItem.ToString();
            UpdateMainFont();
        }

        /// <summary>
        /// Нажали кнопку "Восстановить по-умолчанию"
        /// </summary>
        private void RestoreDefaultSettings(object sender, EventArgs e)
        {
            var defaultSettings = new Settings()
            {
                ExamplesCount = 10,

                MainFontName = "Times New Roman",
                MainFontSize = 12,
                ExamplesFontName = "Times New Roman",
                ExamplesFontSize = 12,
                NotesFontName = "Times New Roman",
                NotesFontSize = 12,

                BackgroundId = 0,
                StretchBackground = false
            };
            _settings = defaultSettings;
            
            ApplySettings();
        }

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        private void SaveSettings(object sender, EventArgs e)
        {
            SettingsManager.SaveSettings(_settings);
            Close();
        }

        /// <summary>
        /// Изменилось фоновое изображение основного окна
        /// </summary>
        private void BackrgoundImageChanged(object sender, EventArgs e)
        {
            try
            {
                int newBackgroundId = comboBoxImages.SelectedIndex;
                string imageName = "../Resource/Backgrounds/" + newBackgroundId + ".jpg";
                _settings.BackgroundId = newBackgroundId;

                Image newBackground = Image.FromFile(imageName);
                pictureBox1.BackgroundImage = newBackground;
                _mainForm.BackgroundImage = newBackground;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch
            {
                MessageBox.Show("Не удаётся обнаружить задний фон с указанным ID, вероятнее всего указанный файл был удалён", "Файл отсутсвует!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Вспомогательные функции

        /// <summary>
        /// Загрзка настроек из файла конфигурации
        /// </summary>
        private void LoadSettings()
        {
            _settings = SettingsManager.LoadSettings();
        }

        /// <summary>
        /// Применить настройки к элементам управления
        /// </summary>
        /// <param name="_settings">Новые настройки</param>
        private void ApplySettings()
        {
            // Число примеров
            numericUpDownExamples.Value = _settings.ExamplesCount;
            _mainForm.ChangeExamplesCount(_settings.ExamplesCount);

            // Шрифты
            comboBoxFont.SelectedIndex = comboBoxFont.Items.IndexOf(_settings.MainFontName);
            comboBoxExamplesFont.SelectedIndex = comboBoxExamplesFont.Items.IndexOf(_settings.ExamplesFontName);
            comboBoxNotesFont.SelectedIndex = comboBoxNotesFont.Items.IndexOf(_settings.NotesFontName);
            numericUpDownMainFont.Value = _settings.MainFontSize;
            numericUpDownExamplesFont.Value = _settings.ExamplesFontSize;
            numericUpDownNotesFont.Value = _settings.NotesFontSize;
            UpdateMainFont();
            UpdateExamplesFont();

            // Задний фон
            comboBoxImages.SelectedIndex = _settings.BackgroundId;
            string imageName = "../Resource/Backgrounds/" + _settings.BackgroundId + ".jpg";
            pictureBox1.BackgroundImage = Image.FromFile(imageName);
            _mainForm.BackgroundImage = Image.FromFile(imageName);
            radioButtonYes.Checked = _settings.StretchBackground;
            radioButtonNo.Checked = !_settings.StretchBackground;
            _mainForm.BackgroundImageLayout = _settings.StretchBackground ? ImageLayout.Stretch : ImageLayout.Tile;
        }

        /// <summary>
        /// Обновить основной шрифт элементов управления приложения
        /// </summary>
        private void UpdateMainFont()
        {
            Font currentFont = new Font(_settings.MainFontName, _settings.MainFontSize);
            foreach (Control ctrl in Controls)
            {
                ctrl.Font = currentFont;
            }
            _mainForm.ChangeFont(currentFont);
        }

        /// <summary>
        /// Обновить шрифт примеров
        /// </summary>
        private void UpdateExamplesFont()
        {
            Font examplesFont = new Font(_settings.ExamplesFontName, _settings.ExamplesFontSize);
            _mainForm.ChangeExamplesFont(examplesFont);
        }

        #endregion
    }
}
