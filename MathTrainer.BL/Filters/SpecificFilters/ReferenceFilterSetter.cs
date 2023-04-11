namespace MathTrainer.BL.Filters
{
    /// <summary>
    /// Класс, отвечающий за применение фильтров, связанных с ссылками на определённые цифры внутри числа, либо на цифры внутри другого числа
    /// </summary>
    public static class ReferenceFilterSetter
    {
        /// <summary>
        /// Код посещённой ссылки
        /// </summary>
        private static readonly int VisitedReferenceCode = 10;

        /// <summary>
        /// Код ссылки на другое число (данный код прибавляется к коду ссылки на позицию цифры, т.е. например, если ссылка ведёт на 3 цифру другого числа, то код будет равен 23
        /// </summary>
        private static readonly int ReferenceToAnotherNumberCode = 20;

        /// <summary>
        /// Применить ссылочный фильтр (модификатор) к числу А или В
        /// </summary>
        /// <param name="refsArray1">Массив ссылок, применимых к первому числу А</param>
        /// <param name="refsArray2">Массив ссылок, применимых ко второму числу В</param>
        /// <param name="index">Индекс цифры в массиве цифр, из которого состоит число А или В, к которой будет применён фильтр по ссылке</param>
        /// <param name="digits1">Массив цифр, из которых состоит первое число А</param>
        /// <param name="digits2">Массив цифр, из которых состоит второе число В</param>
        public static void ApplyReferenceFilter(int[] refsArray1, int[] refsArray2, int index, int[] digits1, int[] digits2)
        {
            Start:
            if (refsArray1[index] == VisitedReferenceCode)
            {
                return;
            }

            // Ссылка ссылается на объект внутри первого массива
            if (refsArray1[index] < ReferenceToAnotherNumberCode)
            {
                // Если ссылка ссылается на другую ссылку, которая обратно ссылается на неё
                if (index == refsArray1[refsArray1[index]])
                {
                    refsArray1[index] = VisitedReferenceCode;
                }
                // Если ссылка ссылается на другую ссылку внутри массива
                else if (refsArray1[refsArray1[index]] != VisitedReferenceCode)
                {
                    int newIndex = refsArray1[index];
                    ApplyReferenceFilter(refsArray1, refsArray2, newIndex, digits1, digits2);
                    goto Start; 
                }
                // Если ссылка ссылается на конкретное число
                else
                {
                    digits1[index] = digits1[refsArray1[index]];
                    refsArray1[index] = VisitedReferenceCode;
                }
            }
            // Если ссылка ссылается на объект в другом объекте
            else
            {
                // Если ссылка ссылается на другую ссылку, которая обратно ссылается на неё
                if (refsArray1[index] == refsArray2[index])
                {
                    refsArray1[index] = VisitedReferenceCode; 
                }
                // Если ссылка ссылается на другую ссылку внутри массива
                else if (refsArray2[refsArray1[index] - ReferenceToAnotherNumberCode] != VisitedReferenceCode)
                {
                    int newIndex = refsArray1[index] - ReferenceToAnotherNumberCode;
                    ApplyReferenceFilter(refsArray2, refsArray1, newIndex, digits2, digits1);
                    goto Start; 
                }
                // Если ссылка ссылается на конкретное число
                else
                {
                    digits1[index] = digits2[refsArray1[index] - ReferenceToAnotherNumberCode];
                    refsArray1[index] = VisitedReferenceCode; 
                }
            }
        }

        /// <summary>
        /// Сгенерировать массив ссылок на конкретные цифры самого числа, либо второго числа
        /// </summary>
        /// <param name="filterString">Набор текстовых фильтров, применимых к числу А или В</param>
        /// <param name="firstNumberSize">Размер первого числа (количество цифр, из которых оно состоит)</param>
        /// <param name="secondNumberSize">Размер второго числа (количество цифр, из которых оно состоит)</param>
        /// <returns></returns>
        public static int[] GenerateArrayOfRefferences(string[] filterString, int firstNumberSize, int secondNumberSize)
        {
            var refsArray = new int[firstNumberSize];
            for (int i = 0; i < firstNumberSize; i++)
            {
                refsArray[i] = GetReference(filterString[i], i, firstNumberSize, secondNumberSize);
            }
            return refsArray;
        }

        /// <summary>
        /// Получить ссылку для выбранно цифры
        /// </summary>
        /// <param name="referenceCode">Код ссылки, может быть как от "=1" до "=7", так и "=" </param>
        /// <param name="index">Индекс цифры числа А или В, значение которой будет получено с помощью ссылки</param>
        /// <param name="firstNumberSize">Размер первого числа А (количество цифр)</param>
        /// <param name="secondNumberSize">Размер второго числа В (количество цифр)</param>
        /// <returns></returns>
        private static int GetReference(string referenceCode, int index, int firstNumberSize, int secondNumberSize)
        {
            int returnedIndex = VisitedReferenceCode;
            if (index <= firstNumberSize - 1)
            {
                if (referenceCode == "=>")
                {
                    returnedIndex = (index > 0) ? index - 1 : VisitedReferenceCode;
                }
                else if (referenceCode == "<=")
                {
                    returnedIndex = (index < firstNumberSize - 1) ? index + 1 : VisitedReferenceCode;
                }
                else if (referenceCode == "=")
                {
                    returnedIndex = (index <= secondNumberSize - 1) ? ReferenceToAnotherNumberCode + index : VisitedReferenceCode;
                }
                else if (referenceCode[0] == '=')
                {
                    int referedIndex = referenceCode[1] - '0';
                    returnedIndex = (firstNumberSize >= referedIndex) ? referedIndex - 1 : VisitedReferenceCode;
                }
                else returnedIndex = VisitedReferenceCode;
            }

            return returnedIndex;
        }
    }
}
