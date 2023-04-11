using System.Collections.Generic;
using System;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;

namespace MathTrainer.BL
{
    /// <summary>
    /// Класс, отвечающий за генерацию примеров (задач), удовлетворяющих заданным условиям
    /// </summary>
    public class ProblemsToSolveGenerator
    {
        /// <summary>
        /// Максимальное количество возможных примеров
        /// <para>На самом деле примеров всегда столько, пользователь выбирает лишь количество отображаемых</para>
        /// </summary>
        private const int ProblemsCount = 10;
        
        #region Закрытые поля
        /// <summary>
        /// Текущая выбранная операция, совершаемая над числами А и В
        /// </summary>
        private IOperation _currentOperation;

        /// <summary>
        /// Обозначение текущей операции
        /// </summary>
        private string _operationName { set; get; }

        /// <summary>
        /// Генератор пар чисел, участвующих в примерах
        /// </summary>
        private NumbersGenerator _generator;

        /// <summary>
        /// Список ответов к примерам
        /// </summary>
        private List<double> _answers;

        /// <summary>
        /// Массив первых чисел, участвующих в примерах
        /// </summary>
        private int[] A;

        /// <summary>
        /// Массив вторых чисел, участвующих в примерах
        /// </summary>
        private int[] B;

        #endregion

        #region Открытые поля

        /// <summary>
        /// Число, отвечающее за разрядность (количество цифр) числа А
        /// </summary>
        public int M = 2;

        /// <summary>
        /// Число, отвечающее за разрядность (количество цифр) числа В
        /// </summary>
        public int N = 2;

        /// <summary>
        /// Используется ли фильтр, применяемый к числам А и В
        /// </summary>
        public bool UseFilters { get; set; } = false;

        /// <summary>
        /// Список текстов примеров
        /// </summary>
        public List<string> TrainingText;
        #endregion

        /// <summary>
        /// Конструктор класса, в котором происходит инициализация полей
        /// </summary>
        public ProblemsToSolveGenerator()
        {
            _currentOperation = new Addition();
            _generator = new GeneratorForAddition();
            _operationName = "+";

            A = new int[ProblemsCount];
            B = new int[ProblemsCount];

            _answers = new List<double>();
            TrainingText = new List<string>();
        }

        #region Основные методы класса

        /// <summary>
        /// Сгененрировать числа А и В для всех примеров
        /// </summary>
        /// <param name="currentFilter">Фильтр, который необходимо применить к генерируемым числам</param>
        public void GenerateNumbers(Filter currentFilter = null)
        {
            if (UseFilters && currentFilter != null)
            {
                FilterSetter.SetFilterSettings(currentFilter, M, N);
            }

            for (int i = 0; i < ProblemsCount; i++)
            {
                _generator.Generate(M, N);
                A[i] = _generator.NumberA;
                B[i] = _generator.NumberB;

                if (UseFilters && currentFilter != null)
                {
                    FilterSetter.ApplyFilter(ref A[i], ref B[i]);
                }
            }
        }

        /// <summary>
        /// Решить все сгененрированные примеры
        /// </summary>
        public void Solve()
        {
            _answers.Clear();
            for (int i = 0; i < ProblemsCount; i++)
            {
                _answers.Add(_currentOperation.Execute(A[i], B[i]));
            }
        }

        /// <summary>
        /// Сформировать текст примеров
        /// </summary>
        /// <param name="showAnswers">Показывать ли ответы к сформированным примерам</param>
        public void GenerateProblemsText(bool showAnswers)
        {
            TrainingText.Clear();
            StringBuilder tempString = new StringBuilder("");
            for (int i = 0; i < ProblemsCount; i++)
            {
                tempString.Append(" ").Append(i + 1).Append(") ");
                if (i < 9) tempString.Append("  ");
                tempString.Append(A[i]).Append(" ").Append(_operationName).Append(" ").Append(B[i]).Append(" = ");
                if (showAnswers)
                {
                    double temp = Math.Round(_answers[i], 3);
                    tempString.Append(temp);
                }
                TrainingText.Add(tempString.ToString());
                tempString.Clear();
            }
        }

        /// <summary>
        /// Сменить текущую операцию, выполняемую над числами
        /// </summary>
        /// <param name="operationId">Номер операции</param>
        public void ChangeOperation(int operationId)
        {
            switch (operationId)
            {
                case 1:
                    _operationName = "+";
                    _currentOperation = new Addition();
                    _generator = new GeneratorForAddition();
                    break;
                case 2:
                    _operationName = "-";
                    _currentOperation = new Subtraction();
                    _generator = new GeneratorForSubtraction();
                    break;
                case 3:
                    _operationName = "*";
                    _currentOperation = new Multiplication();
                    _generator = new GeneratorForAddition();
                    break;
                case 4:
                    _operationName = "/";
                    _currentOperation = new Dividing();
                    _generator = new GeneratorForSubtraction();
                    break;
                case 5:
                    _operationName = "^";
                    _currentOperation = new Exponentiation();
                    _generator = new GeneratorForDegreeOperations();
                    break;
                case 6:
                    _operationName = "^1/";
                    _currentOperation = new Square();
                    _generator = new GeneratorForDegreeOperations();
                    break;
            }
        }

        #endregion
    }
}
