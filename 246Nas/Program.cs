namespace _246Nas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ваяы", 2001, "246");

            
            student.Phone = "fghdfghdfhdf";

            student.AvgBall = 4.7;

            Console.WriteLine(student.ShowStudent());
            Console.WriteLine($"Мне {student.CalcAge()} годиков!");

            Teacher teacher1 = new Teacher("Аввп", 1920);

            teacher1.Hours = 4545;

            Console.WriteLine(teacher1.ShowTeacher());

            Teacher teacher2 = new Teacher("dfhdfhdf", 1990);

            teacher2.Hours = 555;

            List<Student> students = new List<Student>();   
            List<Teacher> teachers = new List<Teacher>();

            students.Add(student);

            teachers.Add(teacher1);
            teachers.Add(teacher2);
            //
            Console.WriteLine("Преподы: ");
            foreach (Teacher t in teachers)
            {
                Console.WriteLine(t.ShowTeacher());
            }
            Console.WriteLine("СТуденты: ");
            foreach (Student s in students)
            {
                Console.WriteLine(s.ShowStudent());
            }
            //
            List<Person> people = new List<Person>();
            people.Add(student);
            people.Add(teacher1);
            people.Add(teacher2);
            Console.WriteLine("Все: ");
            foreach(Person p in people)
            {
                Console.WriteLine(p.ShowInfo());
            }
        }
    }
}
