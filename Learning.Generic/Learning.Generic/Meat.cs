using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Generic
{
    internal class Meat<T> : Product<T>
                where T : struct, IComparable<T>
    {
        public Meat(string name, decimal price, T volume) : base(name, price, volume) { }
        public static Meat<T> operator +(Meat<T> a, T value)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Объект Meat<T> равен null");
            }

            try
            {
                dynamic volumeA = a._volume;
                dynamic volumeB = value;
                a.Volume = volumeA + volumeB; // Меняем значение через свойство (запишется в историю)
                return a;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                throw new InvalidOperationException("Тип T не поддерживает оператор +");
            }


        }
        public static Meat<T> operator -(Meat<T> a, T value)
        {
            if (a is null)
            {
                throw new ArgumentNullException(nameof(a), "Объект Meat<T> равен null");
            }

            try
            {
                dynamic volumeA = a._volume;
                dynamic volumeB = value;
                a.Volume = volumeA - volumeB; // Меняем значение через свойство (запишется в историю)
                return a;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                throw new InvalidOperationException("Тип T не поддерживает оператор +");
            }


        }
    }
}
