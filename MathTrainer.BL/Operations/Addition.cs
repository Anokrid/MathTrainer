namespace MathTrainer.BL
{
    /// <summary>
    /// Операция сложения двух чисел
    /// </summary>
    public class Addition : IOperation
    {
        public double Execute(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
