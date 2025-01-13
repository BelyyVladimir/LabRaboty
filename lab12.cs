using System;
using System.Text;

namespace Lab0612
{
    class Person
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }

        public Person(string fullName, int birthYear)
        {
            FullName = fullName;
            BirthYear = birthYear;
        }
    }

    class Student : Person
    {
        public int[] Grades { get; set; }

        public Student(string fullName, int birthYear, int[] grades) : base(fullName, birthYear)
        {
            Grades = grades;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ФИО: {FullName}; Год рождения: {BirthYear}; Оценки: {String.Join(' ', Grades)}");
        }
    }

    class Teacher : Person
    {
        public string[] Disciplines { get; set; }

        public Teacher(string fullName, int birthYear, string[] disciplines) : base(fullName, birthYear)
        {
            Disciplines = disciplines;
        }

        public void ShowInfo()
        {
            string[] capitalizedDisciplines = new string[Disciplines.Length];
            for (int i = 0; i < Disciplines.Length; i++)
                capitalizedDisciplines[i] = Char.ToUpper(Disciplines[i][0]) + Disciplines[i].Substring(1).ToLower();

            Console.WriteLine($"ФИО: {FullName}; Год рождения: {BirthYear}; Предметы: {String.Join(", ", capitalizedDisciplines)}");
        }
    }

    class Program
    {
        static void WaitForContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main()
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            Student[] students = new Student[1];
            Teacher[] teachers = new Teacher[1];
            bool isEmpty = true;
            bool shouldExit = false;

            while (!shouldExit)
            {
                Console.WriteLine("Выберите опцию от 1 до 5:");
                Console.WriteLine("\t1. Заполнение");
                Console.WriteLine("\t2. Вывод");
                Console.WriteLine("\t3. Выборка студентов по году");
                Console.WriteLine("\t4. Выборка преподавателей по предмету");
                Console.WriteLine("\t5. Выход");

                int selectedOption = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (selectedOption)
                {
                    case 1:
                        if (!isEmpty)
                        {
                            Console.WriteLine("Список уже заполнен");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Введите количество студентов");
                        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
                        students = new Student[numberOfStudents];

                        Console.WriteLine("Введите ФИО, год рождения и оценки (через пробел) через \"/\" ");
                        for (int i = 0; i < numberOfStudents; i++)
                        {
                            string[] studentData = Console.ReadLine().Split('/');
                            string[] inputGrades = studentData[2].Split();
                            int[] grades = new int[inputGrades.Length];
                            for (int j = 0; j < inputGrades.Length; j++)
                                grades[j] = Convert.ToInt32(inputGrades[j]);

                            students[i] = new Student(studentData[0], Convert.ToInt32(studentData[1]), grades);
                        }

                        Console.WriteLine("Введите количество преподавателей");
                        int numberOfTeachers = Convert.ToInt32(Console.ReadLine());
                        teachers = new Teacher[numberOfTeachers];

                        Console.WriteLine("Введите ФИО, год рождения и предметы (через запятую с пробелом) через \"/\" ");
                        for (int i = 0; i < numberOfTeachers; i++)
                        {
                            string[] teacherData = Console.ReadLine().Split('/');
                            string[] disciplines = teacherData[2].Split(", ");
                            for (int j = 0; j < disciplines.Length; j++)
                                disciplines[j] = disciplines[j].Trim().ToLower();

                            teachers[i] = new Teacher(teacherData[0], Convert.ToInt32(teacherData[1]), disciplines);
                        }

                        isEmpty = false;
                        WaitForContinue();
                        break;

                    case 2:
                        if (isEmpty)
                        {
                            Console.WriteLine("Список пуст");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Студенты:");
                        foreach (var student in students)
                            student.ShowInfo();

                        Console.WriteLine("\nПреподаватели:");
                        foreach (var teacher in teachers)
                            teacher.ShowInfo();

                        WaitForContinue();
                        break;

                    case 3:
                        if (isEmpty)
                        {
                            Console.WriteLine("Список пуст");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Введите год рождения для поиска студентов");
                        int searchYear = Convert.ToInt32(Console.ReadLine());

                        foreach (var student in students)
                        {
                            if (student.BirthYear == searchYear)
                                student.ShowInfo();
                        }

                        WaitForContinue();
                        break;

                    case 4:
                        if (isEmpty)
                        {
                            Console.WriteLine("Список пуст");
                            WaitForContinue();
                            break;
                        }

                        Console.WriteLine("Введите название предмета для поиска преподавателей");
                        string searchSubject = Console.ReadLine().ToLower();

                        foreach (var teacher in teachers)
                        {
                            if (Array.Exists(teacher.Disciplines, d => d.ToLower() == searchSubject))
                                teacher.ShowInfo();
                        }

                        WaitForContinue();
                        break;

                    case 5:
                        shouldExit = true;
                        break;
                }
            }
        }
    }
}
