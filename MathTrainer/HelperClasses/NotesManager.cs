using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace MathTrainer
{
    /// <summary>
    /// Класс, позволяющий считывать заметки из файла, а также сохранять изменения в них
    /// </summary>
    public static class NotesManager
    {
        /// <summary>
        /// Путь к файлу с заметками
        /// </summary>
        private static readonly string NotesFileName = "../Resource/notes.json";

        /// <summary>
        /// Загрузить список сохранённых заметок
        /// </summary>
        /// <returns></returns>
        public static List<Note> LoadNotes()
        {
            var notes = new List<Note>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));

            using (FileStream fs = new FileStream(NotesFileName, FileMode.Open))
            {
                notes = (List<Note>)jsonFormatter.ReadObject(fs);
            }

            return notes;
        }

        /// <summary>
        /// Сохранить заметки в файл
        /// </summary>
        /// <param name="notes">Список заметок</param>
        public static void SaveNotes(List<Note> notes)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));
            using (FileStream fs = new FileStream(NotesFileName, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, notes);
            }
        }
    }
}
