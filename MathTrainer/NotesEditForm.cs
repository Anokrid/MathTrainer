using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathTrainer
{
    /// <summary>
    /// Окно, позволяющее менять название и текст заметок
    /// </summary>
    public partial class NotesEditForm : Form
    {
        #region Закрытые поля

        /// <summary>
        /// Окно просмотра и выбора зметок (родительское окно)
        /// </summary>
        private NotesForm _notesForm;

        /// <summary>
        /// Является ли данное окно редактором или конструктором заметок
        /// </summary>
        private bool _isEditForm = false; 
        #endregion

        /// <summary>
        /// Конструктор окна создания/редактирования заметок
        /// </summary>
        /// <param name="notesForm">Окно, в котором отображаются все заметки</param>
        /// <param name="isEdit">Выбрана ли операция редактирования, либо создание новой заметки
        /// <para><b>true</b> - осуществляется редактирование уже существующей заметки</para>
        /// <para><b>false</b> - создаётся новая заметка</para></param>
        public NotesEditForm(NotesForm notesForm, bool isEdit)
        {
            _isEditForm = isEdit;
            _notesForm = notesForm;

            InitializeComponent();
            if (isEdit)
            {
                Text = "Изменение заметки";
                Icon = new Icon("../Resource/Icons/Edit.ico");
                FillText();
            }

            buttonSave.Click += SaveChanges;
            buttonClear.Click += ClearAllText;

            FontSetter.SetMainFont(Controls);
        }

        #region Обработка событий

        /// <summary>
        /// Событие по нажатию кнопки "Очистить"
        /// </summary>
        private void ClearAllText(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxNote.Text = "";
        }

        /// <summary>
        /// Событие по нажатию кнопки "Сохранить"
        /// </summary>
        private void SaveChanges(object sender, EventArgs e)
        {
            var newNote = new Note(textBoxName.Text, textBoxNote.Text);

            if (_isEditForm)
            {
                _notesForm.UpdateCurrentNote(newNote);
            }
            else
            {
                _notesForm.AddNewNote(newNote);
            }

            Close();
        } 
        #endregion

        /// <summary>
        /// Заполнить текстовые поля текстом редактируемой заметки
        /// </summary>
        public void FillText()
        {
            int index = _notesForm.SelectedNoteIndex;
            textBoxName.Text = _notesForm.CurrentNotes[index].Name;
            textBoxNote.Text = _notesForm.CurrentNotes[index].Text;
        }
    }
}
