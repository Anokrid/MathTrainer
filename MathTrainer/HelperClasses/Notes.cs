using System.Runtime.Serialization;

namespace MathTrainer
{
    /// <summary>
    /// Заметка о чём-либо, которую можно просмотреть
    /// </summary>
    [DataContract]
    public class Note
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        [DataMember]
        public string Name;

        /// <summary>
        /// Содержание заметки
        /// </summary>
        [DataMember]
        public string Text;

        /// <summary>
        /// Создание новой заметки
        /// </summary>
        /// <param name="name">Название/заголовок заметки</param>
        /// <param name="text">Текст заметки</param>
        public Note(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}
