using System;

namespace MathTrainer.BL
{
    /// <summary>
    /// Операция возведения первого числа в степень, равную второму числу
    /// </summary>
    public class Exponentiation : IOperation
    {
        public double Execute(int number1, int number2)
        {
            double num = Math.Pow(number1, number2);
            return num;
        }
    }
}
