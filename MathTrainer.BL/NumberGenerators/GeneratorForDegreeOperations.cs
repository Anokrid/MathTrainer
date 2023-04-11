namespace MathTrainer.BL
{
    /// <summary>
    /// Генератор двух чисел А и В для примеров с возведением в степень или извлечением корня
    /// </summary>
    public class GeneratorForDegreeOperations : NumbersGenerator
    {
        public override void Generate(int m, int n)
        {
            NumberA = GetRandomInt(m);
            NumberB = n;
        }
    }
}
