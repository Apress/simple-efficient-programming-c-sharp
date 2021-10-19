﻿using System;

namespace TemplateMethodDemo
{
    /// <summary>
    /// Basic skeleton of action steps
    /// </summary>
    public abstract class Device
    {

        //The following method(step) will NOT vary
        private void VisitShowroom()
        {
            Console.WriteLine("1.The customer visits a dealer showroom.");
        }
        //The following method(step) will NOT vary
        private void GenerateBill()
        {
            Console.WriteLine("3.The bill is printed.");
        }
        private void DeliverProduct()
        {
            Console.WriteLine("4.The product is delivered.\n");
        }
        /*
        The following method will vary. It will be 
        overridden by derived classes.
        */

        protected abstract void SelectProduct();

        //The template method
        public void PurchaseProduct()
        {
            //Step-1
            VisitShowroom();
            //Step-2: Specialized action
            SelectProduct();
            //Step-3
            GenerateBill();
            //Step-4
            DeliverProduct();
        }
    }

    //The concrete derived class-Television
    public class Television : Device
    {
        protected override void SelectProduct()
        {
            Console.WriteLine("2.The customer purchases a television.");
        }
    }

    //The concrete derived class-WashingMachine
    public class WashingMachine : Device
    {
        protected override void SelectProduct()
        {
            Console.WriteLine("2.The customer purchases a washing machine.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***A demonstration of a template Method.***\n");
            Console.WriteLine("---The customer wants a television.---");
            Device device = new Television();
            device.PurchaseProduct();

            Console.WriteLine("---The customer wants a washing machine.---");
            device = new WashingMachine();
            device.PurchaseProduct();

            Console.ReadLine();
        }
    }
}
