﻿using System;

namespace WithoutDIPDemo
{
    class UserInterface
    {
        readonly OracleDatabase oracleDatabase;
        public UserInterface()
        {
            this.oracleDatabase = new OracleDatabase();
        }
        public void SaveEmployeeId(string empId)
        {
            // Assume that this is a valid data.
            // So,I store it to the database.
            oracleDatabase.SaveEmpIdInDatabase(empId);
        }
    }
    class OracleDatabase
    {
        public void SaveEmpIdInDatabase(string empId)
        {
            Console.WriteLine($"The id: {empId} is saved in the oracle database.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demo without DIP.***");
            UserInterface userInterface = new UserInterface();
            userInterface.SaveEmployeeId("E001");
            Console.ReadKey();
        }
    }
}

