namespace MathTrainer.BL
{
    /// <summary>
    /// Генератор двух чисел А и В для примеров со сложением или умножением
    /// </summary>
    public class GeneratorForAddition : NumbersGenerator
    {
        public override void Generate(int m, int n)
        {
            NumberA = GetRandomInt(m);
            NumberB = GetRandomInt(n);
        }
    }
}
