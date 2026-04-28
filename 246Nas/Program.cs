namespace _246Nas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект студента
            Student student = new Student("Ваяы", 2001, "246");

            // Задаём телефон студенту
            student.Phone = "fghdfghdfhdf";

            // Задаём средний балл студента
            student.AvgBall = 4.7;

            // Выводим полную информацию о студенте
            Console.WriteLine(student.ShowStudent());

            // Выводим возраст студента, вычисленный методом базового класса Person
            Console.WriteLine($"Мне {student.CalcAge()} годиков!");

            // Создаём первого преподавателя
            Teacher teacher1 = new Teacher("Аввп", 1920);

            // Задаём количество часов преподавателю
            teacher1.Hours = 4545;

            // Выводим информацию о первом преподавателе
            Console.WriteLine(teacher1.ShowTeacher());

            // Создаём второго преподавателя
            Teacher teacher2 = new Teacher("dfhdfhdf", 1990);

            // Задаём количество часов второму преподавателю
            teacher2.Hours = 555;

            // Создаём отдельный список студентов
            List<Student> students = new List<Student>();

            // Создаём отдельный список преподавателей
            List<Teacher> teachers = new List<Teacher>();

            // Добавляем студента в список студентов
            students.Add(student);

            // Добавляем преподавателей в список преподавателей
            teachers.Add(teacher1);
            teachers.Add(teacher2);

            // Выводим всех преподавателей
            Console.WriteLine("Преподы: ");
            foreach (Teacher t in teachers)
            {
                Console.WriteLine(t.ShowTeacher());
            }

            // Выводим всех студентов
            Console.WriteLine("СТуденты: ");
            foreach (Student s in students)
            {
                Console.WriteLine(s.ShowStudent());
            }

            // Создаём общий список людей типа Person
            // В него можно добавлять и студентов, и преподавателей,
            // потому что они наследуются от класса Person
            List<Person> people = new List<Person>();

            // Добавляем в общий список студента и преподавателей
            people.Add(student);
            people.Add(teacher1);
            people.Add(teacher2);

            // Выводим всех людей через базовый класс Person
            Console.WriteLine("Все: ");
            foreach (Person p in people)
            {
                Console.WriteLine(p.ShowInfo());
            }
        }
    }
}