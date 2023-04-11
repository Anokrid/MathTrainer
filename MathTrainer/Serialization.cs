using System.Runtime.Serialization;

namespace MathTrainer
{
        [DataContract]
        public class Settings
        {
            [DataMember]    // Число одновременно выводимых примеров
            public int NumOfExamples { get; set; }

            [DataMember]    // Основной шрифт приложения   
            public int CurrentFont { get; set; }
            [DataMember]
            public string CurrentFontName { get; set; }
            [DataMember]    // Размер основного шрифта приложения
            public int FontSize { get; set; }

            [DataMember]    // Шрифт заметок
            public int CurrentNotesFont { get; set; }
            [DataMember]
            public string CurrentNotesFontName { get; set; }
            [DataMember]    // Размер основного шрифта приложения
            public int NotesFontSize { get; set; }

            [DataMember]    // Шрифт примеров
            public int CurrentExamplesFont { get; set; }
            [DataMember]
            public string CurrentExamplesFontName { get; set; }
            [DataMember]    // Размер шрифта примеров
            public int ExamplesFontSize { get; set; }

            [DataMember]    // Номер заднего фона приложения
            public int BackgroundNumber { get; set; }
            [DataMember]    // Растягивать ли изображение?
            public bool Stretch { get; set; }

            public Settings() { }
        }  
}
