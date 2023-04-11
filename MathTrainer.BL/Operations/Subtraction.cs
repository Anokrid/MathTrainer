namespace MathTrainer.BL
{
    /// <summary>
    /// Операция вычитания одного числа из другого
    /// </summary>
    public class Subtraction : IOperation
    {
        public double Execute(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
