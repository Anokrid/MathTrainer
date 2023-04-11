namespace MathTrainer.BL
{
    /// <summary>
    /// Генератор двух чисел А и В для примеров с вычитанием или делением
    /// </summary>
    public class GeneratorForSubtraction : NumbersGenerator
    {
        public override void Generate(int m, int n)
        {
            NumberA = GetRandomInt(m);
            NumberB = GetRandomInt(n);
            if (NumberB > NumberA)
            {
                (NumberA, NumberB) = (NumberB, NumberA);
            }
        }
    }
}
