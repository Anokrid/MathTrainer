using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace MathTrainer.BL
{
    /// <summary>
    /// Класс, который имеет доступ к фильтрам, применяемым к генерируемым числам, и умеет выполнять над фильтрами определённые операции
    /// </summary>
    public class FiltersStorage
    {
        #region Закрытые поля
        /// <summary>
        /// Имя файла, в котором хранятся фильтры
        /// </summary>
        private string _fileName = "../Resource/filters.json";

        /// <summary>
        /// Список доступных фильтров, применяемых к числам А и В
        /// </summary>
        private List<Filter> _possibleFilters;

        #endregion

        #region Публичные свойства

        /// <summary>
        /// Получить список доступных фильтров
        /// </summary>
        /// <returns></returns>
        public List<Filter> GetFiletrsList => _possibleFilters;

        /// <summary>
        /// Получение описание текущего фильтра
        /// </summary>
        /// <returns></returns>
        public string GetCurrentFilterDescription => _possibleFilters[CurrentFilterIndex].Description;

        /// <summary>
        /// Получить выбранный фильтр
        /// </summary>
        /// <returns></returns>
        public Filter GetCurrentFilter => _possibleFilters[CurrentFilterIndex];

        /// <summary>
        /// Индекс выбранного фильтра
        /// </summary>
        public int CurrentFilterIndex { get; set; }

        #endregion

        public FiltersStorage()
        {
            _possibleFilters = new List<Filter>();
            CurrentFilterIndex = -1;
            LoadFilters();
        }

        #region Основные методы

        /// <summary>
        /// Загрузить список фильтров из файла
        /// </summary>
        public void LoadFilters()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Filter>));
            using (FileStream fs = new FileStream(_fileName, FileMode.Open))
            {
                _possibleFilters = (List<Filter>)jsonFormatter.ReadObject(fs);
            }
        }

        /// <summary>
        /// Сохранить текущий набор фильтров в файл
        /// </summary>
        public void SaveNewFilters()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Filter>));
            using (FileStream fs = new FileStream(_fileName, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, _possibleFilters);
            }
        }

        /// <summary>
        /// Добавить новы фильтр к списку уже имеющихся
        /// </summary>
        /// <param name="filter">Фильтр, который необходимо добавить</param>
        public void AddFilter(Filter filter)
        {
            _possibleFilters.Add(filter);
            SaveNewFilters();
        }

        /// <summary>
        /// Обновить текущий фильтр
        /// </summary>
        /// <param name="newFilter">Новый фильтр, который будет записан вместо старого</param>
        /// <param name="oldFilterId">Индекс фильтра, которого необходимо обновить</param>
        public void UpdateFilter(Filter newFilter, int oldFilterId)
        {
            _possibleFilters[oldFilterId] = newFilter;
            SaveNewFilters();
        }

        /// <summary>
        /// Удалить фильтр из общего списка
        /// </summary>
        /// <param name="filterId">Номер фильтра в списке</param>
        public void DeleteFilter(int filterId)
        {
            _possibleFilters.RemoveAt(filterId);
            SaveNewFilters();
        } 
        #endregion
    }
}
