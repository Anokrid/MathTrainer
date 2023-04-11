using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;

namespace MathTrainer
{
    public partial class NotesForm : Form
    {
        public List<Notes> notes;
        public static bool NotesEditWasCreated = false;
        // Шрифт приложения и заметок
        public Font currentFont;
        public Font currentNotesFont;

        public NotesForm()
        {
            InitializeComponent();
            notes = new List<Notes>();

            buttonConfirm.Visible = false;

            LoadNotes();    // Загрузка заметок
            LoadConfig();   // Загрузка шрифтов

            toolTip1.SetToolTip(buttonAdd, "Добавить заметку");
            toolTip1.SetToolTip(buttonDelete, "Удалить заметку");
            toolTip1.SetToolTip(buttonEdit, "Редактировать заметку");

            buttonAdd.Click += ButtonAdd_Click;

            buttonEdit.Click += ButtonEdit_Click;

            buttonDelete.Click += ButtonDelete_Click;

            buttonConfirm.Click += ButtonConfirm_Click;

            labelNote.Click += LabelNote_Click;

            comboBoxNames.SelectionChangeCommitted += ComboBoxNames_SelectionChangeCommitted;
        }

        // Событие по выбору элемента в списке заметок
        private void ComboBoxNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (buttonConfirm.Visible) buttonConfirm.Visible = false;
            UpdateCurrentText();
        }

        // Событие по щелчку на текстовое поле
        private void LabelNote_Click(object sender, EventArgs e)
        {
            if (buttonConfirm.Visible) buttonConfirm.Visible = false;
        }

        // Событие по подтверждению удаления заметки
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            int remouvingIndex = comboBoxNames.SelectedIndex;
            notes.RemoveAt(remouvingIndex);
            comboBoxNames.Items.RemoveAt(remouvingIndex);
            if (remouvingIndex > 0) comboBoxNames.SelectedIndex = remouvingIndex - 1;

            labelNote.Text = "";

            buttonConfirm.Visible = false;

            SaveNotes();
        }

        // Событие по нажатию кнопки удалить
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxNames.SelectedIndex >= 0) buttonConfirm.Visible = true;
        }

        // Событие по нажатию кнопки "Изменить"
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (buttonConfirm.Visible) buttonConfirm.Visible = false;

            if ((!NotesEditWasCreated) && (comboBoxNames.SelectedIndex >= 0))
            {
                NotesEdit notesEdit = new NotesEdit(this, true);
                notesEdit.Location = Location;
                notesEdit.Text = "Изменение заметки";
                notesEdit.Icon = new Icon("../Resource/Icons/Edit.ico");
                notesEdit.FillText(comboBoxNames.SelectedIndex);
                notesEdit.Show();
                NotesEditWasCreated = true;
            }
        }

        // Событие по нажатию кнопки "Добавить"
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (buttonConfirm.Visible) buttonConfirm.Visible = false;

            if (!NotesEditWasCreated)
            {
                NotesEdit notesEdit = new NotesEdit(this, false);
                notesEdit.Location = Location;
                notesEdit.Show();
                NotesEditWasCreated = true;
            }
        }

        // Обновление списка заметок после добавления новой
        public void UpdateBoxOfNames(Notes _notes)
        {
            comboBoxNames.Items.Add(_notes.Name);
            SaveNotes();
        }

        // Обновление текушей заметки
        public void UpdateCurrentNote(Notes _notes)
        {
            notes[comboBoxNames.SelectedIndex].Name = _notes.Name;

            notes[comboBoxNames.SelectedIndex].Note = _notes.Note;
            
            comboBoxNames.Items[comboBoxNames.SelectedIndex] = _notes.Name;
            UpdateCurrentText();

            SaveNotes();
        }

        // Записать заметки в файл сохранения
        public void SaveNotes()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Notes>));
            using (FileStream fs = new FileStream("../Resource/notes.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, notes);
            }

        }

        // Загрузить заметки из файла
        public void LoadNotes()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Notes>));

            using (FileStream fs = new FileStream("../Resource/notes.json", FileMode.Open))
            {
                notes = (List<Notes>)jsonFormatter.ReadObject(fs);
            }

            for (int i=0; i<notes.Count; i++)
            {
                comboBoxNames.Items.Add(notes[i].Name);
            }
        }

        // Обновить текст заметки
        private void UpdateCurrentText()
        {
            labelNote.Text = "";
            labelNote.Text = notes[comboBoxNames.SelectedIndex].Note;
        }

        // Загрузка конфигурации
        private void LoadConfig()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Settings));

            Settings settings = new Settings(); 
            
            using (FileStream fs = new FileStream("../Resource/settings.json", FileMode.Open))
            {
                settings = (Settings)jsonFormatter.ReadObject(fs);
            }

            // Создание основного шрифта
            string _currentFont = settings.CurrentFontName;
            currentFont = new Font(_currentFont, settings.FontSize);

            // Устанавливаем элементам управления основной шрифт
            labelNames.Font = currentFont;
            comboBoxNames.Font = currentFont;
            buttonConfirm.Font = currentFont;

            currentNotesFont = new Font(settings.CurrentNotesFontName, settings.NotesFontSize);

            labelNote.Font = currentNotesFont;
        }
    }
}
