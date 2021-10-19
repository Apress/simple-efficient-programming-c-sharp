using System;

namespace WithoutSRPDemo
{
    class Employee
    {
        public string empFirstName, empLastName, empId;
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

        public string CheckSeniority(double experienceInYears)
        {
            if (experienceInYears > 5)
                return "senior";
            else
                return "junior";
        }
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
            Console.WriteLine("*** A demo without SRP.***");
            Employee robin = new Employee("Robin", "Smith", 7.5);
            robin.DisplayEmployeeDetail();
            string empId = robin.GenerateEmployeeId(robin.empFirstName);
            Console.WriteLine($"The employee id: {empId}");

            Console.WriteLine($"This employee is a " +
                $"{robin.CheckSeniority(robin.experienceInYears)} employee.");

            Console.WriteLine("\n*******\n");

            Employee kevin = new Employee("Kevin", "Proctor", 3.2);
            kevin.DisplayEmployeeDetail();
            empId = kevin.GenerateEmployeeId(kevin.empFirstName);
            Console.WriteLine($"The employee id: {empId}");
            Console.WriteLine($"This employee is a " +
                $"{kevin.CheckSeniority(kevin.experienceInYears)} employee.");

            Console.ReadKey();
        }
    }
}
