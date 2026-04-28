using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _246Nas
{
    // Класс Teacher наследуется от класса Person
    internal class Teacher : Person
    {
        // Количество учебных часов преподавателя
        public int Hours { get; set; }

        // Конструктор класса Teacher:
        // вызывает конструктор базового класса Person
        public Teacher(string Name, int YearOfBird)
            : base(Name, YearOfBird)
        {
        }

        // Метод для вывода полной информации о преподавателе
        public string ShowTeacher()
        {
            // Получаем информацию из базового класса Person
            string s = base.ShowInfo();

            // Добавляем информацию, относящуюся только к преподавателю
            s += $"Кол-во часов: {Hours}\n" +
                 $"----------------------\n";

            return s;
        }
    }
}