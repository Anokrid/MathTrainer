using System;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class NotesEdit : Form
    {
        NotesForm notesForm;
        public bool isEditForm = false;

        // Конструктор класса
        public NotesEdit(NotesForm notesForm, bool isEdit)
        {
            isEditForm = isEdit;

            InitializeComponent();

            this.notesForm = notesForm;

            buttonSave.Click += ButtonSave_Click;
            buttonClear.Click += ButtonClear_Click;

            ChangeFont();
        }

        // Событие по нажатию кнопки "Очистить"
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBox1.Text = "";
        }

        // Событие по нажатию кнопки "Сохранить"
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Notes newNotes = new Notes(textBoxName.Text);
            newNotes.Note = textBox1.Text;

            if (!isEditForm)
            {
                notesForm.notes.Add(newNotes);
                notesForm.UpdateBoxOfNames(newNotes);
            }
            else
            {
                notesForm.UpdateCurrentNote(newNotes);
            }
            
            Close();
        }

        // Заполнение текстовых полей текстом из редактируемой заметки
        public void FillText(int index)
        {
            textBoxName.Text = notesForm.notes[index].Name;

            textBox1.Text = notesForm.notes[index].Note;
        }

        // Смена шрифта
        private void ChangeFont()
        {
            textBoxName.Font = notesForm.currentFont;
            buttonSave.Font = notesForm.currentFont;
            buttonClear.Font = notesForm.currentFont;

            textBox1.Font = notesForm.currentNotesFont;
        }
    }
}
