using System;

namespace VehicleDemo
{
    #region Inheritance chain-1
    interface ICapability
    {
        void CurrentCapability();
    }
    class FloatCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It can float now.");
        }
    }
    class FlyCapability : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It can fly now.");
        }
    }
    class DoNothing : ICapability
    {
        public void CurrentCapability()
        {
            Console.WriteLine("It does nothing.");
        }
    }
    #endregion
    #region Inheritance chain-2
    abstract class Vehicle
    {

        protected string vehicleType = String.Empty;
        protected ICapability vehicleBehavior;
        protected string registrationNumber = String.Empty;
        public abstract void SetVehicleBehavior(ICapability behavior);
        public abstract void DisplayDetails();

    }
    class Boat : Vehicle
    {
        public Boat(string registrationId)
        {
            this.registrationNumber = registrationId;
            this.vehicleType = "Boat";
            this.vehicleBehavior = new DoNothing();
        }
        public override void SetVehicleBehavior(ICapability behavior)
        {
            this.vehicleBehavior = behavior;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Current status of the boat:");
            Console.WriteLine($"Registration number:{this.registrationNumber}");
            vehicleBehavior.CurrentCapability();

        }
    }
    #endregion
    class Airplane : Vehicle
    {
        public Airplane(string registrationId)
        {
            this.registrationNumber = registrationId;
            this.vehicleType = "Airplane";
            this.vehicleBehavior = new DoNothing();
        }
        public override void SetVehicleBehavior(ICapability behavior)
        {
            this.vehicleBehavior = behavior;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Current status of the airplane:");
            Console.WriteLine($"Registration number:{this.registrationNumber}");
            vehicleBehavior.CurrentCapability();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("***Vehicles demo.***");
                Vehicle vehicle = new Boat("B001");
                vehicle.DisplayDetails();
                Console.WriteLine("****************");

                ICapability currentCapability = new FloatCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("****************");

                vehicle = new Airplane("A002");
                currentCapability = new FlyCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("****************");

                Console.WriteLine("Adding float behavior to the airplane.");
                //Adding float capability to an airplane
                currentCapability = new FloatCapability();
                vehicle.SetVehicleBehavior(currentCapability);
                vehicle.DisplayDetails();
                Console.WriteLine("****************");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
        }
    }
}
