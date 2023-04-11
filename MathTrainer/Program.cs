using System;
using System.Windows.Forms;
using MathTrainer.BL;

namespace MathTrainer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            ProblemsToSolveGenerator manager = new ProblemsToSolveGenerator();
            MainPresenter presenter = new MainPresenter(form, manager);

            Application.Run(form);
        }
    }
}
