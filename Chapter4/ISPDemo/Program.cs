using System;

namespace ISPDemo
{
    interface IPrinter
    {
        void PrintDocument();
    }
    interface IFaxDevice
    {
        void SendFax();
    }
    class BasicPrinter : IPrinter
    {
        public void PrintDocument()
        {
            Console.WriteLine("A basic printer can print documents.");
        }
    }
    class AdvancedPrinter : IPrinter, IFaxDevice
    {
        public void PrintDocument()
        {
            Console.WriteLine("An advanced printer can print documents.");
        }
        public void SendFax()
        {
            Console.WriteLine("An advanced printer can send a fax.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demo that follows ISP.***");

            IPrinter printer = new BasicPrinter();
            printer.PrintDocument();
            printer = new AdvancedPrinter();
            printer.PrintDocument();            

            IFaxDevice faxDevice = new AdvancedPrinter();
            faxDevice.SendFax();

            Console.ReadKey();
        }
    }
}
