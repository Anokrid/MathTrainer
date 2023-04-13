using System;
using System.Collections.Generic;

namespace MathTrainer
{
    /// <summary>
    /// Интерфейс для взаимодействия с UI программы
    /// </summary>
    public interface IMainForm
    {
        #region Свойства
        /// <summary>
        /// Индекс текущей операции, для которой генерируются примеры
        /// </summary>
        int OperationId { get; }

        /// <summary>
        /// Число, отвечающее за разрядность первого числа А, которое будет участвовать в примерах
        /// </summary>
        int GetM { get; }

        /// <summary>
        /// Число, отвечающее за разрядность второго числа В, которое будет участвовать в примерах
        /// </summary>
        int GetN { get; }

        /// <summary>
        /// Индекс выбранного фильтра
        /// </summary>
        int CurrentFilterIndex { get; }

        /// <summary>
        /// Выбранный фильтр
        /// </summary>
        Filter CurrentFilter { get; set; }

        /// <summary>
        /// Использовать или нет фильтры к генерируемым числам
        /// </summary>
        bool UseFilters { get; }

        #endregion

        #region События
        /// <summary>
        /// Был добавлен новый фильтр
        /// </summary>
        event EventHandler FilterWasAdded;

        /// <summary>
        /// Был выбран новый фильтр
        /// </summary>
        event EventHandler FilterWasChanged;

        /// <summary>
        /// Изменился статус использования фильтров
        /// </summary>
        event EventHandler UseFilterChanged;

        /// <summary>
        /// Выбранный фильтр был обновлён
        /// </summary>
        event EventHandler<FilterEventArgs> FilterWasUpdated;
        
        /// <summary>
        /// Выбранный фильтр был удалён
        /// </summary>
        event EventHandler<FilterEventArgs> FilterWasDeleted;

        /// <summary>
        /// Операция, выполняемая над числами А и В, была изменена
        /// </summary>
        event EventHandler ChangeOperation;

        /// <summary>
        /// Была нажата кнопка генерации примеров
        /// </summary>
        event EventHandler GenerateClick;

        /// <summary>
        /// Была нажата кнопка показа ответов
        /// </summary>
        event EventHandler ShowAnswersClick;

        #endregion

        #region Методы

        /// <summary>
        /// Изменить текст примеров
        /// </summary>
        /// <param name="Examples">Перечень примеров</param>
        void ChangeProblemsText(List<string> Examples);

        /// <summary>
        /// Загрузить фильтры для их отображения
        /// </summary>
        /// <param name="filters">Список фильтров к числам</param>
        void LoadFilters(List<Filter> filters);

        /// <summary>
        /// Изменить описание фильтра
        /// </summary>
        /// <param name="description">Новое описание фильтра</param>
        void ChangeFilterDescription(string description); 
        #endregion
    }
}
