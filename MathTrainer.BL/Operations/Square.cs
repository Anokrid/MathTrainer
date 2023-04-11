using System;

namespace MathTrainer.BL
{
    /// <summary>
    /// Операция извлечения корня произвольной степени (соответствует второму числу) из первого числа
    /// </summary>
    public class Square : IOperation
    {
        public double Execute(int number1, int number2)
        {
            double num = Math.Pow(number1, 1.0 / number2);
            return num;
        }
    }
}
