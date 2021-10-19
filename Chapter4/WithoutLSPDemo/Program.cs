using System;
using System.Collections.Generic;

namespace WithoutLSPDemo
{
    interface IUser
    {
        void LoadPreviousPaymentInfo();
        void ProcessNewPayment();
    }
    class RegisteredUser : IUser
    {
        string name = String.Empty;
        public RegisteredUser(string name)
        {
            this.name = name;
        }
        public void LoadPreviousPaymentInfo()
        {
            Console.WriteLine($"Welcome, {name}. Here are your last payment details.");
        }

        public void ProcessNewPayment()
        {
            Console.WriteLine($"Processing {name}'s current payment request.");
        }
    }

    class GuestUser : IUser
    {
        string name = String.Empty;
        public GuestUser()
        {
            this.name = "guest user";
        }

        public void LoadPreviousPaymentInfo()
        {
            throw new NotImplementedException();
        }

        public void ProcessNewPayment()
        {
            Console.WriteLine($"Processing {name}'s current payment request.");
        }
    }

    class UserManagementHelper
    {
        List<IUser> users = new List<IUser>();
        public void AddUser(IUser user)
        {
            users.Add(user);
        }
        public void ShowPreviousPayments()
        {
            foreach (IUser user in users)
            {
                user.LoadPreviousPaymentInfo();                
                Console.WriteLine("------");
            }
        }
        public void ProcessNewPayments()
        {
            foreach (IUser user in users)
            {
                user.ProcessNewPayment();
                Console.WriteLine("***********");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demo without LSP.***");
            UserManagementHelper helper = new UserManagementHelper();

            // Instantiating two registered users
            RegisteredUser robin = new RegisteredUser("Robin");
            RegisteredUser jack = new RegisteredUser("Jack");

            // Adding the users to usermanager
            helper.AddUser(robin);
            helper.AddUser(jack);

            // Processing the payments using
            // the helper class.            
            helper.ShowPreviousPayments();
            helper.ProcessNewPayments();

            
            //GuestUser guestUser1 = new GuestUser();
            //helper.AddUser(guestUser1);

            //// Processing the payments using 
            //// the helper class.
            //// You can see the problem now.
            //helper.ShowPreviousPayments();
            //helper.ProcessNewPayments();
            
            Console.ReadKey();
        }
    }
}
