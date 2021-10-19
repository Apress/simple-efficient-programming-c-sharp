using System;

namespace SRPDemo
{
    class Employee
    {
        public string empFirstName, empLastName;
        public double experienceInYears;
        public Employee(string firstName, string lastName, double experience)
        {
            this.empFirstName = firstName;
            this.empLastName = lastName;
            this.experienceInYears = experience;
        }
        public void DisplayEmployeeDetail()
        {
            Console.WriteLine($"The employee name: {empLastName}, {empFirstName}");
            Console.WriteLine($"This employee has {experienceInYears} years of experience.");
        }
    }
    class SeniorityChecker
    {
        public string CheckSeniority(double experienceInYears)
        {
            if (experienceInYears > 5)
                return "senior";
            else
                return "junior";
        }

    }
    class EmployeeIdGenerator
    {
        string empId;
        public string GenerateEmployeeId(string empFirstName)
        {
            int random = new System.Random().Next(1000);
            empId = String.Concat(empFirstName[0], random);
            return empId;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** A demo that follows SRP.***");

            Employee robin = new Employee("Robin", "Smith", 7.5);
            PrintEmployeeDetail(robin);
            PrintEmployeeId(robin);
            PrintSeniorityLevel(robin);

            Console.WriteLine("\n*******\n");

            Employee kevin = new Employee("Kevin", "Proctor", 3.2);
            PrintEmployeeDetail(kevin);
            PrintEmployeeId(kevin);
            PrintSeniorityLevel(kevin);

            Console.ReadKey();
        }
        private static void PrintEmployeeDetail(Employee emp)
        {
            emp.DisplayEmployeeDetail();
        }

        private static void PrintEmployeeId(Employee emp)
        {
            EmployeeIdGenerator idGenerator = new EmployeeIdGenerator();
            string empId = idGenerator.GenerateEmployeeId(emp.empFirstName);
            Console.WriteLine($"The employee id: {empId}");
        }
        private static void PrintSeniorityLevel(Employee emp)
        {
            SeniorityChecker seniorityChecker = new SeniorityChecker();
            string seniorityLevel = seniorityChecker.CheckSeniority(emp.experienceInYears);
            Console.WriteLine($"This employee is a {seniorityLevel} employee.");
        }
    }
}
