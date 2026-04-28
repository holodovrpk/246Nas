using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _246Nas
{
    // Базовый класс Person описывает человека
    internal class Person
    {
        // Имя человека
        public string Name { get; set; }

        // Приватное поле для хранения года рождения
        private int yearOfBird;

        // Свойство YearOfBird с проверкой:
        // год рождения должен быть больше 1900
        public int YearOfBird
        {
            get { return yearOfBird; }
            set
            {
                if (value > 1900)
                    yearOfBird = value;
            }
        }

        // Телефон человека
        public string Phone { get; set; }

        // Конструктор класса:
        // задаёт имя и год рождения
        public Person(string Name, int YearOfBird)
        {
            this.Name = Name;
            this.YearOfBird = YearOfBird;
        }

        // Метод для вычисления возраста человека
        public int CalcAge()
        {
            int age = DateTime.Now.Year - YearOfBird;
            return age;
        }

        // Метод для вывода информации о человеке
        public string ShowInfo()
        {
            return $"-----------------------\n" +
                   $"Имя: {Name}\n" +
                   $"Год рождения: {YearOfBird}\n" +
                   $"Телефон: {Phone}\n";
        }
    }
}