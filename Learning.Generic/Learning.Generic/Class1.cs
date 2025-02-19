using System;
using System.Diagnostics;
using System.Xml.Linq;


namespace Learning.Generic
{
    internal class Product<T>
        where T : struct, IComparable<T>
    {
        protected decimal _price { get; set; }
        public string _name { get; set; }

        protected List<T> _history = new List<T>(); // История изменений объема
        protected T _volume { get; set; }

        public T Volume
        {
            get => _volume;
            protected set
            {
                _volume = value;
                _history.Add(value); // Записываем каждое изменение
            }
        }

        public Product(string name, decimal price, T volume)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Введите имя");
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Цена не может быть меньше или равна нулю");
            if (volume.CompareTo(default) < 0)
                throw new ArgumentOutOfRangeException(nameof(volume), "Количество не может быть меньше 0");

            _name = name;
            _price = price;
            Volume = volume; // Используем свойство, чтобы записать в историю
        }
        public override string ToString()
        {
            return $"Название продукта: {_name}, Цена продукта за 1 кг: {_price} рублей, Количество продукта на складе: {_volume} кг.";
        }

        public void PrintHistory()
        {
            Console.WriteLine($"История изменений объема для {_name}:");
            foreach (var v in _history)
            {
                Console.WriteLine(v);
            }
        }
    }
}
