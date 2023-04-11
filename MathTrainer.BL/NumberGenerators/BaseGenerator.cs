using System;

namespace MathTrainer.BL
{
    /// <summary>
    /// Абстрактный генератор двух чисел А и В, которые будут участвовать в примерах
    /// </summary>
    public abstract class NumbersGenerator
    {
        private Random _rnd;

        /// <summary>
        /// Первое число, участвующее в примерах
        /// </summary>
        public int NumberA;

        /// <summary>
        /// Второе число, участвующее в примерах
        /// </summary>
        public int NumberB;

        /// <summary>
        /// Возвращает случайное число с заданным количеством знаков
        /// </summary>
        /// <param name="length">Желаемая размерность числа (количество знаков числа)</param>
        /// <returns></returns>
        public int GetRandomInt(int length)
        {
            int max = (int)(Math.Pow(10, length));
            int min = max / 10;

            return _rnd.Next(min, max);
        }

        /// <summary>
        /// Сгенерировать числа А и В
        /// </summary>
        /// <param name="m">Размерность первого числа</param>
        /// <param name="n">Размерность второго числа (но для операций с возведением в степень - размер степени)</param>
        public abstract void Generate(int m, int n);

        public NumbersGenerator()
        {
            _rnd = new Random();
        }
    }
}
