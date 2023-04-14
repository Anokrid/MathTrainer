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
        private static readonly string NotesFileName = "\\Resources\\notes.json";

        /// <summary>
        /// Загрузить список сохранённых заметок
        /// </summary>
        /// <returns></returns>
        public static List<Note> LoadNotes()
        {
            var notes = new List<Note>();
            string path = DirectoryManager.TryToFindValidPathToFile(NotesFileName);
            if (!File.Exists(path))
            {
                return notes;
            }

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
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
            string path = DirectoryManager.TryToFindValidPathToFile(NotesFileName);
            
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Note>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, notes);
            }
        }
    }
}
