using System;
using System.Xml.Linq;


namespace Learning.OperatorOverloading
{
    internal class Animal
    {
        public string AnimalName { get; set; }
        public double AnimalWeight { get; set; }

        public string AnimalMaster { get; set; }

        public string AnimalSound { get; set; }

        public Animal(string _name, string _masterName, double _weight)
        {
            if (string.IsNullOrWhiteSpace(_name))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            if (string.IsNullOrWhiteSpace(_masterName))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            if (_weight <= 0) 
            {
                throw new ArgumentException("Вес не может быть равен или меньше 0");
            } 

            AnimalName = _name;
            AnimalMaster = _masterName;
            AnimalWeight = _weight;
                
        }
        public static Animal operator +(Animal a1, Animal a2)
        {
            return new Animal($"{a1.AnimalName} и {a2.AnimalName}",a1.AnimalMaster, a1.AnimalWeight+a2.AnimalWeight);
        }
        public override string ToString()
        {
            return $"{AnimalMaster} - хозяин {AnimalName}, общий вес {AnimalWeight} гр.";
        }
        public static bool operator ==(Animal animal1, Animal animal2)
        {
            return animal1.AnimalWeight == animal2.AnimalWeight;
        }
        public static bool operator !=(Animal animal1, Animal animal2)
        {
            return false;
        }
    } 

}
    

