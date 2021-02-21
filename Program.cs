using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsMarks
{
    class Student //Declare the class 
    {
        public string FirstName { get; set; }
        public string SecName { get; set; }
        public float Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecName}: {Grade:F2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(numberStudents);

            for (int i = 0; i < numberStudents; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ');

                Student student = new Student()
                {  //Object Initializer !
                    FirstName = data[0],
                    SecName = data[1],
                    Grade = float.Parse(data[2])
                
                }; // create a current student from the class

                students.Add(student);
            }

            List<Student> sortedByGrade = new List<Student>(students.Count);
            sortedByGrade = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach  (Student student in sortedByGrade)
            {
                Console.WriteLine(student);
            }
        }
    }
}
