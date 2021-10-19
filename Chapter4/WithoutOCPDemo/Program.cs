using System;
using System.Collections.Generic;

namespace WithoutOCPDemo
{
    class Student
    {
        internal string name;
        internal string registrationNumber;
        internal string department;
        internal double score;
        public Student(string name,
                       string registrationNumber,
                       double score,
                       string department)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.score = score;
            this.department = department;
        }
        public override string ToString()
        {
            return ($"Name: {this.name} " +
                $"\nReg Number: {this.registrationNumber} " +
                $"\nDept: {this.department} " +
                $"\nscore: {this.score}" +
                $"\n*******");
        }
    }
    class DistinctionDecider
    {
        public void EvaluateDistinction(Student student)
        {

            if (student.department == "Science")
            {
                if (student.score > 80)
                {
                    Console.WriteLine($"{student.registrationNumber} has received a distinction in science.");
                }
            }

            if (student.department == "Arts")
            {
                if (student.score > 70)
                {
                    Console.WriteLine($"{student.registrationNumber} has received a distinction in arts.");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** A demo without OCP.***");
            List<Student> enrolledStudents = MakeStudentList();

            // Display results.
            Console.WriteLine("===Results:===");
            foreach (Student student in enrolledStudents)
            {
                Console.WriteLine(student);
            }

            // Evaluate distinctions. 
            DistinctionDecider distinctionDecider = new DistinctionDecider();
            Console.WriteLine("===Distinctions:===");
            foreach (Student student in enrolledStudents)
            {
                distinctionDecider.EvaluateDistinction(student);
            }

            Console.ReadKey();
        }

        private static List<Student> MakeStudentList()
        {
            Student sam = new Student("Sam", "R001", 81.5, "Science");
            Student bob = new Student("Bob", "R002", 72, "Science");
            Student john = new Student("John", "R003", 71, "Arts");
            Student kate = new Student("Kate", "R004", 66.5, "Arts");

            List<Student> students = new List<Student>();
            students.Add(sam);
            students.Add(bob);
            students.Add(john);
            students.Add(kate);
            return students;
        }
    }
}
