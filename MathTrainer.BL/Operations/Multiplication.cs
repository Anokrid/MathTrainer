namespace MathTrainer.BL
{
    /// <summary>
    /// Операция умножения двух чисел
    /// </summary>
    public class Multiplication : IOperation
    {
        public double Execute(int number1, int number2)
        {
            return (double)number1 * (double)number2;
        }
    }
}
