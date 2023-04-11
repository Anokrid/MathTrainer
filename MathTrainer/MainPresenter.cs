using System;
using MathTrainer.BL;

namespace MathTrainer
{
    /// <summary>
    /// Презентер, осуществляющий взаимодействие UI с бизнес-логикой
    /// </summary>
    class MainPresenter
    {
        /// <summary>
        /// UI приложения
        /// </summary>
        private readonly IMainForm _view;

        /// <summary>
        /// Модель, реализующая логику генерации примеров
        /// </summary>
        private readonly ProblemsToSolveGenerator _problemsManager;

        /// <summary>
        /// Модель, отвечающая за взаимодействие с фильтрами, применяемыми к числам
        /// </summary>
        private readonly FiltersStorage _filtersManager;

        /// <summary>
        /// Конструктор презентера
        /// </summary>
        /// <param name="view">Часть приложения, отвечающая за UI</param>
        /// <param name="manager">Часть приложения, отвечающая за бизнес-логику</param>
        public MainPresenter(IMainForm view, ProblemsToSolveGenerator manager)
        {
            _view = view;
            _problemsManager = manager;
            _filtersManager = new FiltersStorage();

            view.GenerateClick += View_GenerateClick;
            view.ShowAnswersClick += View_ShowAnswersClick;
            view.ChangeOperation += View_ChangeOperation;

            view.FilterWasAdded += View_FilterWasAdded;
            view.UseFilterChanged += View_UseFilterChanged;
            view.FilterWasChanged += View_FilterWasChanged;
            view.FilterWasUpdated += View_FilterWasUpdated;
            view.FilterWasDeleted += View_FilterWasDeleted;

            view.LoadFilters(_filtersManager.GetFiletrsList);
        }

        /// <summary>
        /// Событие: фильтр был удалён
        /// </summary>
        private void View_FilterWasDeleted(object sender, FilterEventArgs e)
        {
            _filtersManager.DeleteFilter(e.index);
        }

        /// <summary>
        /// Событие: обновился фильтр
        /// </summary>
        private void View_FilterWasUpdated(object sender, FilterEventArgs e)
        {
            _filtersManager.UpdateFilter(e.filter, e.index);
        }

        /// <summary>
        /// Событие: изменился выбранный фильтр
        /// </summary>
        private void View_FilterWasChanged(object sender, EventArgs e)
        {
            _filtersManager.CurrentFilterIndex = _view.CurrentFilterIndex;
            string descrition = _filtersManager.GetCurrentFilterDescription;
            _view.ChangeFilterDescription(descrition);
            _view.CurrentFilter = _filtersManager.GetCurrentFilter;
        }

        /// <summary>
        /// Событие: фильтр теперь используется/ненужен
        /// </summary>
        private void View_UseFilterChanged(object sender, EventArgs e)
        {
            _problemsManager.UseFilters = _view.UsingFilters;
        }

        /// <summary>
        /// Событие: был добавлен новый фильтр
        /// </summary>
        private void View_FilterWasAdded(object sender, EventArgs e)
        {
            _filtersManager.AddFilter(_view.CurrentFilter);
        }

        /// <summary>
        /// Событие: была выбрана новая операция (сложение/вычитание/умножение/деление)
        /// </summary>
        private void View_ChangeOperation(object sender, EventArgs e)
        {
            _problemsManager.ChangeOperation(_view.OperationId + 1);
        }

        /// <summary>
        /// Событие: была нажата кнопка показать ответы
        /// </summary>
        private void View_ShowAnswersClick(object sender, EventArgs e)
        {
            _problemsManager.Solve();
            _problemsManager.GenerateProblemsText(true);
            _view.ChangeText(_problemsManager.TrainingText);
        }

        /// <summary>
        /// Событие: была нажата кнопка сгенерировать примеры
        /// </summary>
        private void View_GenerateClick(object sender, EventArgs e)
        {
            _problemsManager.M = _view.GetM;
            _problemsManager.N = _view.GetN;
            if (_filtersManager.CurrentFilterIndex >= 0)
            {
                _problemsManager.GenerateNumbers(_filtersManager.GetCurrentFilter);
            }
            else
            {
                _problemsManager.GenerateNumbers();
            }
            _problemsManager.GenerateProblemsText(false);
            _view.ChangeText(_problemsManager.TrainingText);
        }
    }
}
