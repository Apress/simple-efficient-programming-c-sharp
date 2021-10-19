using System;

namespace ImplementationWithoutFacades
{
    class Person
    {
        public string name;
        public double assetValue;
        public bool previousLoanExist;

        public Person(string name,
            double assetValue = 100000,
            bool previousLoanExist = false)
        {
            this.name = name;
            this.assetValue = assetValue;
            this.previousLoanExist = previousLoanExist;
        }
    }
    class Asset
    {
        public bool HasSufficientAssetValue(Person person, double claimAmount)
        {
            Console.WriteLine($"Verifying whether {person.name} has sufficient asset value.");
            return person.assetValue >= claimAmount ? true : false;
        }
    }

    class LoanStatus
    {
        public bool HasPreviousLoans(Person person)
        {
            Console.WriteLine($"Verifying whether {person.name} has any previous loans.");
            return person.previousLoanExist ? true : false;
            //Simplified statement
            //return person.previousLoanExist;
        }
    }

   
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Directly interacting with the subsystems.***");
            Asset asset = new Asset();
            LoanStatus loanStatus = new LoanStatus();
            string status = "approved";
            string reason = String.Empty;
            bool assetValue, previousLoanExist;

            //Person-1
            Person bob = new Person("Bob", 5000, true);
            
            //Starts background verification
            assetValue = asset.HasSufficientAssetValue(bob, 20000);
            previousLoanExist = loanStatus.HasPreviousLoans(bob);

            if (!assetValue)
            {
                status = "Not approved.";
                reason += "\nInsufficient balance.";
            }
            if (previousLoanExist)
            {
                status = "Not approved.";
                reason += "\nOld loan exists.";
            }
            Console.WriteLine($"{bob.name}'s application status: {status}");
            Console.WriteLine($"Remarks if any: {reason}");           

            Console.ReadKey();
        }
    }
}
