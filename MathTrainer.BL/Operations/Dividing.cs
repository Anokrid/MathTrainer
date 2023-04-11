namespace MathTrainer.BL
{
    /// <summary>
    /// Операция деления одного числа на другое
    /// </summary>
    public class Dividing : IOperation
    {
        public double Execute(int number1, int number2)
        {
            return (double)number1 / number2;
        }
    }
}
