using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    /// <summary>
    /// Множество
    /// </summary>
    /// <typeparam name="T">Тип данных, хранимых во множестве</typeparam>
    public class Set<T>
    {
        ///<summary>
        ///Коллекция хранимых данных
        /// </summary> 
        private List<T> _items = new List<T>();
        ///<summary>
        ///Количество элементов
        /// </summary>
        public int Count => _items.Count;
        ///<summary>
        ///Добавить данные во множество
        /// </summary>
        ///<param name="item"></param>
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }
        ///<summary>
        ///Удалить элемент из множества
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException($"Элемент {item} не найден в множестве");
            }
            _items.Remove(item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var set1 = new Set<int>()
            {
                1, 2, 3, 4, 5
            };
        }
    }
}
