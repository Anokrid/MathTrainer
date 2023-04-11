using System.Collections.Generic;

namespace MathTrainer.BL.Filters
{
    /// <summary>
    /// Класс, отвечающий за применение фильтра суммирования к числам А и В, участвующих в примерах
    /// </summary>
    public static class SumFilterSetter
    {
        /// <summary>
        /// Максимальное значение числа, начиная с которого его не стоит увеличивать
        /// </summary>
        private static readonly int MaxDigitToIncrease = 9;

        /// <summary>
        /// Минимальное значение числа, начиная с которого его не стоит уменьшать
        /// </summary>
        private static readonly int MinDigitToDecrease = 0;
        
        /// <summary>
        /// Применить фильтр суммирования: некоторые цифры из состава чисел А и В будут в сумме давать определённые числа
        /// </summary>
        /// <param name="digits1">Массив цифр, из которых состоит первое число А</param>
        /// <param name="digits2">Массив ссылок, применимых ко второму числу В</param>
        /// <param name="sumCode">Код суммы: от S1 до S5</param>
        /// <param name="filter">Текущий выбранный фильтр, который будет применяться к числам А и В</param>
        public static void ApplySumFilter(int[] digits1, int[] digits2, string sumCode, Filter filter)
        {
            // Создаём списки, в которых будут храниться индексы сумм
            List<int> sumIndexes1 = GenerateArrayOfIndexes(digits1, filter.FilterA, sumCode);
            List<int> sumIndexes2 = GenerateArrayOfIndexes(digits2, filter.FilterB, sumCode);

            int index = sumCode[1] - '0' - 1;
            int wantedSum = filter.Sum[index];
            if (sumIndexes1.Count > 0 || sumIndexes2.Count > 0)
            {
                int currentSum;
                do
                {
                    currentSum = CalculateSumm(sumIndexes1, sumIndexes2, digits1, digits2);

                    if (currentSum < wantedSum)
                    {
                        TryToIncreaseDigits(sumIndexes1, digits1, wantedSum, ref currentSum);
                        if (currentSum == wantedSum) break;
                        else
                        {
                            TryToIncreaseDigits(sumIndexes2, digits2, wantedSum, ref currentSum);
                        }
                    }
                    if (currentSum > wantedSum)
                    {
                        TryToDecreaseDigits(sumIndexes1, digits1, wantedSum, ref currentSum);
                        if (currentSum == wantedSum) break;
                        else
                        {
                            TryToDecreaseDigits(sumIndexes2, digits2, wantedSum, ref currentSum);
                        }
                    }
                }
                while (currentSum != wantedSum);
            }
        }
        
        #region Вспомогательные методы

        /// <summary>
        /// Сгенерировать массив индексов цифр из состава числа А или В, к которым должен быть применён фильтр суммирования
        /// </summary>
        /// <param name="digits">Массив цифр, из которых состоит число А или В</param>
        /// <param name="numberFilters">Список фильтров, применимых к конкретному числу А или В</param>
        /// <param name="sumCode">Код фильтра суммы, согласно которому осуществляется выборка индексов. Код принимает значения от S1 до S5</param>
        /// <returns></returns>
        private static List<int> GenerateArrayOfIndexes(int[] digits, string[] numberFilters, string sumCode)
        {
            var sumIndexes = new List<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (numberFilters[i] == sumCode)
                {
                    sumIndexes.Add(i);
                }
            }
            return sumIndexes;
        }

        /// <summary>
        /// Рассчитать сумму цифр, расположенных по индексам, указанным фильтром
        /// </summary>
        /// <param name="sumIndexes1">Список индексов цифр у первого числа А, которые должны быть просуммированы</param>
        /// <param name="sumIndexes2">Список индексов цифр у второго числа В, которые должны быть просуммированы</param>
        /// <param name="digits1">Массив цифр, из которых состоит первое число А</param>
        /// <param name="digits2">Массив цифр, из которых состоит первое число В</param>
        /// <returns></returns>
        private static int CalculateSumm(List<int> sumIndexes1, List<int> sumIndexes2, int[] digits1, int[] digits2)
        {
            int tempSum = 0;
            // Прибавляем все помеченные цифры из первого и второго числа
            for (int i = 0; i < sumIndexes1.Count; i++)
            {
                tempSum += digits1[sumIndexes1[i]];
            }
            for (int i = 0; i < sumIndexes2.Count; i++)
            {
                tempSum += digits2[sumIndexes2[i]];
            }
            return tempSum;
        }

        /// <summary>
        /// Попытаться увеличить цифры числа А или Б, чтобы достичь желаемую сумму
        /// </summary>
        /// <param name="sumIndexes">Массив индексов цифр числа А или В, которые должны давать желаемую сумму</param>
        /// <param name="digits">Массив цифр, из которых состоит число А или В</param>
        /// <param name="wantedSum">Желаемая сумма цифр</param>
        /// <param name="currentSum">Текущая сумма цифр</param>
        private static void TryToIncreaseDigits(List<int> sumIndexes, int[] digits, int wantedSum, ref int currentSum)
        {
            for (int i = 0; i < sumIndexes.Count; i++)
            {
                if (digits[sumIndexes[i]] < MaxDigitToIncrease)
                {
                    digits[sumIndexes[i]]++;
                    currentSum++;
                }
                if (currentSum == wantedSum) return;
            }
        }

        /// <summary>
        /// Попытаться уменьшить цифры числа А или Б, чтобы достичь желаемую сумму
        /// </summary>
        /// <param name="sumIndexes">Массив индексов цифр числа А или В, которые должны давать желаемую сумму</param>
        /// <param name="digits">Массив цифр, из которых состоит число А или В</param>
        /// <param name="wantedSum">Желаемая сумма цифр</param>
        /// <param name="currentSum">Текущая сумма цифр</param>
        private static void TryToDecreaseDigits(List<int> sumIndexes, int[] digits, int wantedSum, ref int currentSum)
        {
            for (int i = 0; i < sumIndexes.Count; i++)
            {
                if (digits[sumIndexes[i]] > MinDigitToDecrease)
                {
                    digits[sumIndexes[i]]--;
                    currentSum--;
                }
                if (currentSum == wantedSum) return;
            }
        } 
        #endregion
    }
}
