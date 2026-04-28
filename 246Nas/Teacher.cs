using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _246Nas
{
    internal class Teacher : Person
    {
        public int Hours { get; set; }

        public Teacher(string Name, int YearOfBird)
            : base(Name, YearOfBird)
        {      
        }

        public string ShowTeacher()
        {
            string s = base.ShowInfo();

            s += $"Кол-во часов: {Hours}\n" +
                $"----------------------\n";


            return s;
        }
    }
}
