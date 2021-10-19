using System;
using System.Collections.Generic;

namespace LSPDemo
{
    interface IPreviousPayment
    {
        void LoadPreviousPaymentInfo();        
    }
    interface INewPayment
    {        
        void ProcessNewPayment();
    }
    class RegisteredUser : IPreviousPayment, INewPayment
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

    class GuestUser : INewPayment
    {
        string name = String.Empty;
        public GuestUser()
        {
            this.name = "guest user";
        }        

        public void ProcessNewPayment()
        {
            Console.WriteLine($"Processing a {name}'s current payment request.");
        }
    }

    class UserManagementHelper
    {
        List<IPreviousPayment> previousPayments = new List<IPreviousPayment>();
        List<INewPayment> newPaymentRequests = new List<INewPayment>();
        public void AddPreviousPayment(IPreviousPayment previousPayment)
        {
            previousPayments.Add(previousPayment);
        }

        public void AddNewPayment(INewPayment newPaymentRequest)
        {
            newPaymentRequests.Add(newPaymentRequest);
        }
        public void ShowPreviousPayments()
        {
            foreach (IPreviousPayment user in previousPayments)
            {
                user.LoadPreviousPaymentInfo();
                Console.WriteLine("------");
            }
        }
        public void ProcessNewPayments()
        {
            foreach (INewPayment payment in newPaymentRequests)
            {
                payment.ProcessNewPayment();
                Console.WriteLine("***********");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demo that follows LSP.***");
            UserManagementHelper helper = new UserManagementHelper();

            // Instantiating two registered users.
            RegisteredUser robin = new RegisteredUser("Robin");
            RegisteredUser jack = new RegisteredUser("Jack");

            // Adding the info to usermanager.
            helper.AddPreviousPayment(robin);
            helper.AddPreviousPayment(jack);
            helper.AddNewPayment(robin);
            helper.AddNewPayment(jack);

            // Instantiating a guest user.
            GuestUser guestUser1 = new GuestUser();
            helper.AddNewPayment(guestUser1);

            // Retrieve all the previous payments
            // of registered users.
            helper.ShowPreviousPayments();

            // Process all new payment requests
            // from all users.
            helper.ProcessNewPayments();

            Console.ReadKey();
        }
    }
}
