using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _246Nas
{
    internal class Student : Person
    {
        public string Group {  get; set; }

        private double avgBall;
        public double AvgBall
        {
            get { return avgBall; }
            set
            { 
                if (value >= 1 && value <= 5)
                    avgBall = value;
            }
        }

        public Student (string Name, int YearOfBird, string Group)
            : base(Name, YearOfBird)
        {
            this.Group = Group;
        }


        public string ShowStudent()
        {
            string s = base.ShowInfo();

            s += $"Средний балл: {AvgBall}\n" +
                $"Группа: {Group}\n " +
                $"----------------------\n";
            return s;
        }
    }
}
