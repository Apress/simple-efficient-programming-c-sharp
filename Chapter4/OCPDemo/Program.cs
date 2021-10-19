using System;
using System.Collections.Generic;

namespace OCPDemo
{
    class Student
    {
        internal string name;
        internal string registrationNumber;
        internal double score;
        public Student(string name,
                       string registrationNumber,
                       double score                      
                       )
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.score = score;
           
        }
        public override string ToString()
        {
            return ($"Name: {this.name} " +
                $"\nReg Number: {this.registrationNumber} " +                  
                $"\nscore: {this.score}\n*******");
        }
    }

    interface IDistinctionDecider
    {
        void EvaluateDistinction(Student student);
    }
    class ArtsDistinctionDecider : IDistinctionDecider
    {
        public void EvaluateDistinction(Student student)
        {
            if (student.score > 70)
            {
                Console.WriteLine($"{student.registrationNumber} has received a distinction in arts.");
            }
        }
    }

    class ScienceDistinctionDecider : IDistinctionDecider
    {
        public void EvaluateDistinction(Student student)
        {
            if (student.score > 80)
            {
                Console.WriteLine($"{student.registrationNumber} has received a distinction in science.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demo that follows OCP.***");
            List<Student> scienceStudents = MakeScienceStudentList();
            List<Student> artsStudents = MakeArtsStudentList();

            // Display results.
            Console.WriteLine("===Results:===");
            foreach (Student student in scienceStudents)
            {
                Console.WriteLine(student);
            }
            foreach (Student student in artsStudents)
            {
                Console.WriteLine(student);
            }

            // Evaluate distinctions.            
            Console.WriteLine("===Distinctions:===");

            // For science students.
            IDistinctionDecider distinctionDecider = new ScienceDistinctionDecider();
            foreach (Student student in scienceStudents)
            {
                distinctionDecider.EvaluateDistinction(student);
            }

            // For arts students.
            distinctionDecider = new ArtsDistinctionDecider();
            foreach (Student student in artsStudents)
            {
                distinctionDecider.EvaluateDistinction(student);
            }

            Console.ReadKey();
        }

        private static List<Student> MakeScienceStudentList()
        {
            Student sam = new Student("Sam", "R001", 81.5);
            Student bob = new Student("Bob", "R002", 72);
            List<Student> students = new List<Student>();
            students.Add(sam);
            students.Add(bob);
            return students;
        }
        private static List<Student> MakeArtsStudentList()
        {
            Student john = new Student("John", "R003", 71);
            Student kate = new Student("Kate", "R004", 66.5);
            List<Student> students = new List<Student>();
            students.Add(john);
            students.Add(kate);
            return students;
        }
    }
}
