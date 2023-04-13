using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, позволяющее просматривать заметки, созданные пользователем
    /// </summary>
    public partial class NotesForm : Form
    {
        /// <summary>
        /// Индекс редактируемой заметки
        /// </summary>
        private int _editedNoteIndex = -1;

        #region Публичные свойства
        /// <summary>
        /// Списиок текущих заметок
        /// </summary>
        public List<Note> CurrentNotes { get; set; }

        /// <summary>
        /// Индекс выбранной заметки
        /// </summary>
        public int SelectedNoteIndex => comboBoxNames.SelectedIndex;

        /// <summary>
        /// Было создано окно создания/изменения выбранной заметки
        /// </summary>
        public static bool NotesEditWasCreated = false;

        #endregion
        
        public NotesForm()
        {
            InitializeComponent();
            LoadNotes();
            SetFonts();

            toolTip1.SetToolTip(buttonAdd, "Добавить заметку");
            toolTip1.SetToolTip(buttonDelete, "Удалить заметку");
            toolTip1.SetToolTip(buttonEdit, "Редактировать заметку");

            buttonAdd.Click += ButtonAddClick;
            buttonEdit.Click += ButtonEditClick;
            buttonDelete.Click += ButtonDeleteNoteClick;

            comboBoxNames.SelectionChangeCommitted += NoteWasSelected;
        }

        #region Обработка событий

        /// <summary>
        /// Событие по выбору элемента в списке заметок
        /// </summary>
        private void NoteWasSelected(object sender, EventArgs e)
        {
            UpdateCurrentText();
        }

        /// <summary>
        /// Событие по нажатию кнопки "Удалить заметку"
        /// </summary>
        private void ButtonDeleteNoteClick(object sender, EventArgs e)
        {
            if (comboBoxNames.SelectedIndex < 0)
            {
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("Удалить выбранную заметку?", "Подтвердите удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                int remouvingIndex = comboBoxNames.SelectedIndex;
                CurrentNotes.RemoveAt(remouvingIndex);
                comboBoxNames.Items.RemoveAt(remouvingIndex);

                comboBoxNames.SelectedIndex = -1;
                labelNote.Text = "";

                SaveNotes();
            }
        }

        /// <summary>
        /// Событие по нажатию кнопки "Изменить заметку"
        /// </summary>
        private void ButtonEditClick(object sender, EventArgs e)
        {
            if (!NotesEditWasCreated && SelectedNoteIndex >= 0)
            {
                _editedNoteIndex = SelectedNoteIndex;
                CreateNoteEditionForm(true);
            }
        }

        /// <summary>
        /// Событие по нажатию кнопки "Добавить заметку"
        /// </summary>
        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (!NotesEditWasCreated)
            {
                CreateNoteEditionForm(false);
            }
        }
        #endregion

        #region Основные методы

        /// <summary>
        /// Добавить новую заметку
        /// </summary>
        /// <param name="newNote">Новая заметка</param>
        public void AddNewNote(Note newNote)
        {
            CurrentNotes.Add(newNote);
            comboBoxNames.Items.Add(newNote.Name);
            SaveNotes();
        }

        /// <summary>
        /// Обновление ранее выбранной заметки
        /// </summary>
        /// <param name="updatedNote">Обновлённая заметка</param>
        public void UpdateCurrentNote(Note updatedNote)
        {
            comboBoxNames.Items[_editedNoteIndex] = updatedNote.Name;
            CurrentNotes[_editedNoteIndex].Name = updatedNote.Name;
            CurrentNotes[_editedNoteIndex].Text = updatedNote.Text;

            UpdateCurrentText();
            SaveNotes();
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Загрузить заметки из файла
        /// </summary>
        private void LoadNotes()
        {
            CurrentNotes = NotesManager.LoadNotes();

            for (int i = 0; i < CurrentNotes.Count; i++)
            {
                comboBoxNames.Items.Add(CurrentNotes[i].Name);
            }
        }

        /// <summary>
        /// Сохранить заметки в файл
        /// </summary>
        private void SaveNotes()
        {
            NotesManager.SaveNotes(CurrentNotes);
        }

        /// <summary>
        /// Создать окно создания/редкатирования заметки
        /// </summary>
        /// <param name="isEditingForm">Является ли окно редактором, или конструктором
        /// <para><b>true</b> - создаётся окно редактирования существующей заметки</para>
        /// <para><b>false</b> - создаётся окно создания новой заметки</para></param>
        private void CreateNoteEditionForm(bool isEditingForm)
        {
            var notesEdit = new NotesEditForm(this, isEditingForm);
            notesEdit.Location = Location;
            notesEdit.Show();
            NotesEditWasCreated = true;
        }

        /// <summary>
        /// Обновить текст заметки
        /// </summary>
        private void UpdateCurrentText()
        {
            int selectedNodeId = comboBoxNames.SelectedIndex;
            labelNote.Text = CurrentNotes[selectedNodeId].Text;
        }

        /// <summary>
        /// Загрузить и применить шрифты для элементов управления
        /// </summary>
        private void SetFonts()
        {
            var currentFont = FontSetter.GetMainFont();
            var currentNotesFont = FontSetter.GetNotesFont();

            // Устанавливаем элементам управления основной шрифт
            labelNames.Font = currentFont;
            comboBoxNames.Font = currentFont;
            // А для заметок отдельный шрифт
            labelNote.Font = currentNotesFont;
        } 
        #endregion
    }
}
