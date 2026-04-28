using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _246Nas
{
    internal class Person
    {
        public string Name { get; set; }

        private int yearOfBird; 
        public int YearOfBird { get { return yearOfBird; }
            set
            { 
                if (value > 1900)
                    yearOfBird = value;
            } 
        }
        public string Phone {  get; set; }
  

        public Person(string Name, int YearOfBird)
        {
            this.Name = Name;
            this.YearOfBird = YearOfBird;
        }

        public int CalcAge()
        {
            int age = DateTime.Now.Year - YearOfBird;
            return age;
        }

        public string ShowInfo()
        {
            return $"-----------------------\n" +
                $"Имя: {Name}\n" +
                $"Год рождения: {YearOfBird}\n" +
                $"Телефон: {Phone}\n";
        }


    }
}
