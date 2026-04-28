using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _246Nas
{
    // Класс Student наследуется от класса Person
    internal class Student : Person
    {
        // Группа студента
        public string Group { get; set; }

        // Приватное поле для хранения среднего балла
        private double avgBall;

        // Свойство AvgBall с проверкой:
        // средний балл должен быть от 1 до 5
        public double AvgBall
        {
            get { return avgBall; }
            set
            {
                if (value >= 1 && value <= 5)
                    avgBall = value;
            }
        }

        // Конструктор класса Student:
        // вызывает конструктор базового класса Person
        // и дополнительно задаёт группу
        public Student(string Name, int YearOfBird, string Group)
            : base(Name, YearOfBird)
        {
            this.Group = Group;
        }

        // Метод для вывода полной информации о студенте
        public string ShowStudent()
        {
            // Получаем информацию из базового класса Person
            string s = base.ShowInfo();

            // Добавляем информацию, относящуюся только к студенту
            s += $"Средний балл: {AvgBall}\n" +
                 $"Группа: {Group}\n " +
                 $"----------------------\n";

            return s;
        }
    }
}