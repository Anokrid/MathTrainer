namespace MathTrainer.BL
{
    /// <summary>
    /// Операция, которая будет выполнена над двумя числами
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Выполнить операцию и вернуть полученный результат
        /// </summary>
        /// <param name="number1">Первое число</param>
        /// <param name="num2">Второе число</param>
        /// <returns></returns>
        double Execute(int number1, int number2);
    }
}
