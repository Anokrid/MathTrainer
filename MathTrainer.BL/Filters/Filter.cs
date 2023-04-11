using System.Runtime.Serialization;


namespace MathTrainer
{
    /// <summary>
    /// Класс, описывающий фильтр для двух числе А и В, которые участвуют в генерации примеров
    /// </summary>
    [DataContract]
    public class Filter
    {
        /// <summary>
        /// Имя фильтра
        /// </summary>
        [DataMember]
        public string FilterName;

        /// <summary>
        /// Описание фильтра
        /// </summary>
        [DataMember]
        public string Description;
        
        /// <summary>
        /// Список сум, которые могут формировать произвольные разряды чисел А и В
        /// </summary>
        [DataMember]
        public int[] Sum;

        /// <summary>
        /// Текстовый фильтр для первого числа А, который будет учтён при формировании примеров
        /// </summary>
        [DataMember]
        public string[] FilterA;

        /// <summary>
        /// Текстовый фильтр для второго числа В, который будет учтён при формировании примеров
        /// </summary>
        [DataMember]
        public string[] FilterB;

        /// <summary>
        /// Количество доступных сумм произвольных разрядов чисел, которые могут быть использованы для формирования фильтра 
        /// </summary>
        public static int SumsCount = 5;

        /// <summary>
        /// Размер фильтра - максимальное количество разрядов чисел А и В
        /// </summary>
        public static int Dimension = 7;  

        public Filter()
        {
            Sum = new int[SumsCount];
            FilterA = new string[Dimension];
            FilterB = new string[Dimension];
        }
    }
}
