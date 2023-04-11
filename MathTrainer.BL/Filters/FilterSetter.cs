using System;
using System.Linq;
using MathTrainer.BL.Filters;

namespace MathTrainer.BL
{
    /// <summary>
    /// Класс, отвечающий за применение фильтров к числам из примеров
    /// </summary>
    public static class FilterSetter
    {
        #region Закрытые поля

        /// <summary>
        /// Текущий фильтр, применяемый к числам А и В
        /// </summary>
        private static Filter CurrentFilter;

        /// <summary>
        /// Разрядность первого числа
        /// </summary>
        private static int M;

        /// <summary>
        /// Разрядность второго числа
        /// </summary>
        private static int N;

        #endregion

        /// <summary>
        /// Установить настройки применителя фильтра
        /// </summary>
        /// <param name="newFilter">Новый фильтр, применяемый к числам А и В</param>
        /// <param name="m">Разрядность первого числа А</param>
        /// <param name="n">Разрядность второго числа В</param>
        public static void SetFilterSettings(Filter newFilter, int m, int n)
        {
            M = m;
            N = n;
            CurrentFilter = newFilter;
        }

        /// <summary>
        /// Применить фильтр к числам, участвующим в одном примере
        /// </summary>
        /// <param name="number1">Первое число А, к которму будет применён фильтр</param>
        /// <param name="number2">Второе число В, к которму будет применён фильтр</param>
        public static void ApplyFilter(ref int number1, ref int number2)
        {
            // Массивы, в которых числа являются поразрядными цифрами основного числа
            int[] digits1 = SplitNumber(number1, M);
            int[] digits2 = SplitNumber(number2, N);
            
            ApplyDirectValueFilter(CurrentFilter.FilterA, digits1);
            ApplyDirectValueFilter(CurrentFilter.FilterB, digits2);
            TryToApplySumFilter(digits1, digits2);

            // Массивы, в которых будут храниться ссылки на разряды цифр у обоих чисел
            int[] refsArray1 = ReferenceFilterSetter.GenerateArrayOfRefferences(CurrentFilter.FilterA, M, N);
            int[] refsArray2 = ReferenceFilterSetter.GenerateArrayOfRefferences(CurrentFilter.FilterB, N, M);
            TryToApplyRefferenceFilters(refsArray1, refsArray2, digits1, digits2);
            TryToApplyRefferenceFilters(refsArray2, refsArray1, digits2, digits1);

            number1 = UniteNumber(digits1);
            number2 = UniteNumber(digits2);
        }

        #region Вспомогательные методы

        /// <summary>
        /// Разбить число на массив цифр, из которых оно состоит, в обратном порядке
        /// </summary>
        /// <param name="number">Число, которое необходимо разбить</param>
        /// <param name="arraySize">Размер сформированного массива</param>
        /// <returns></returns>
        private static int[] SplitNumber(int number, int arraySize)
        {
            var splited = new int[arraySize];

            int id = 0;
            while (number >= 1)
            {
                int temp = number % 10;
                number /= 10;
                splited[id] = temp;
                id++;
            }

            return splited;
        }

        /// <summary>
        /// Объединить массив цифр в одно число
        /// </summary>
        /// <param name="digits">Массив чисел, расположенных в обратном порядке</param>
        /// <returns></returns>
        private static int UniteNumber(int[] digits)
        {
            int number = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                number += digits[i] * (int)Math.Pow(10, i);
            }
            return number;
        }

        /// <summary>
        /// Применить прямые фильтры, т.е. некоторые цифры числа А или В будут иметь конкретное значение, заданное фильтром, либо принудительно будут чётными или нечётными
        /// </summary>
        /// <param name="filterValues">Набор текстовых фильтров, применимых к конкретному числу А или В</param>
        /// <param name="digits">Массив цифр, из которых состоит число А или В</param>
        private static void ApplyDirectValueFilter(string[] filterValues, int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (filterValues[i].Length == 1 && Int32.TryParse(filterValues[i], out int num))
                {
                    digits[i] = num;
                }
                else if (filterValues[i] == "2N")
                {
                    if (digits[i] % 2 != 0) digits[i] -= 1;
                }
                else if (filterValues[i] == "!2N")
                {
                    if (digits[i] % 2 == 0) digits[i] += 1;
                }
            }
        }

        /// <summary>
        /// Попытаться применить фильтр на суммы цифр чисел А и В
        /// </summary>
        /// <param name="digits1">Массив цифр, из которых состоит первое число А</param>
        /// <param name="digits2">Массив цифр, из которых состоит второе число В</param>
        private static void TryToApplySumFilter(int[] digits1, int[] digits2)
        {
            for (int i = 0; i < Filter.SumsCount; i++)
            {
                string filterCode = "S" + (i + 1).ToString();
                if (CurrentFilter.FilterA.Contains(filterCode) || CurrentFilter.FilterB.Contains(filterCode))
                {
                    SumFilterSetter.ApplySumFilter(digits1, digits2, filterCode, CurrentFilter);
                }
            }
        }

        /// <summary>
        /// Попытаться применить фильтры со ссылками на некоторые цифры из состава чисел А и В
        /// </summary>
        /// <param name="refsArray1">Массив ссылок, применимых к первому числу А</param>
        /// <param name="refsArray2">Массив ссылок, применимых ко второму числу В</param>
        /// <param name="digits1">Массив цифр, из которых состоит первое число А</param>
        /// <param name="digits2">Массив цифр, из которых состоит второе число В</param>
        private static void TryToApplyRefferenceFilters(int[] refsArray1, int[] refsArray2, int[] digits1, int[] digits2)
        {
            for (int i = 0; i < digits1.Length; i++)
            {
                ReferenceFilterSetter.ApplyReferenceFilter(refsArray1, refsArray2, i, digits1, digits2);
            }
        }

        #endregion
    }
}
