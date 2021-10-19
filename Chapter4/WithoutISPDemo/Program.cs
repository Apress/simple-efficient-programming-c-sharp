using System;
using System.Collections.Generic;

namespace WithoutISPDemo
{
    interface IPrinter
    {
        void PrintDocument();
        void SendFax();
    }

    class BasicPrinter : IPrinter
    {
        public void PrintDocument()
        {
            Console.WriteLine("A basic printer can print documents.");
        }

        public void SendFax()
        {
            throw new NotImplementedException();
        }
    }
    class AdvancedPrinter : IPrinter
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
            Console.WriteLine("***A demo without ISP.***");


            IPrinter printer = new AdvancedPrinter();
            printer.PrintDocument();
            printer.SendFax();

            printer = new BasicPrinter();
            printer.PrintDocument();
            //printer.SendFax();//Will throw error
            /*
            List<IPrinter> printers = new List<IPrinter>
                                      { 
                                       new AdvancedPrinter(), 
                                       new BasicPrinter() 
                                       };
            foreach( IPrinter device in printers)
            {
                device.PrintDocument();
                //device.SendFax(); //Will throw error
            }
            */

            Console.ReadKey();
        }
    }
}
