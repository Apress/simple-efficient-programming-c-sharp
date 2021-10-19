using System;
//using System.Collections.Generic;

namespace UsingFacade
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
            //return person.previousLoanExist ? true : false;
            //Simplified statement
            return person.previousLoanExist;
        }
    }

    class LoanApprover
    {
        readonly Asset asset;
        readonly LoanStatus loanStatus;
        public LoanApprover()
        {
            asset = new Asset();
            loanStatus = new LoanStatus();
        }
        public string CheckLoanEligibility(Person person, double claimAmount)
        {
            string status = "approved";
            string reason = String.Empty;
            Console.WriteLine($"\nChecking the loan approval status of {person.name}.");
            Console.WriteLine($"[Current asset value:{person.assetValue}," +
                $"claim amount:{claimAmount}," +
                $"existing loan?:{person.previousLoanExist}.]\n");
            if (!asset.HasSufficientAssetValue(person,claimAmount))
            {
                status = "Not approved.";
                reason += "\nInsufficient balance.";
            }
            if (loanStatus.HasPreviousLoans(person))
            {
                status = "Not approved.";
                reason += "\nOld loan exists.";
            }

            return string.Concat(status, "\nRemarks if any:", reason);
        }
    }
    class Program
    {
        //static void Main(string[] args)

        static void Main()
        {
            Console.WriteLine("***Simplifying the usage of a complex system using a facade.***");
            //Using a facade
            LoanApprover loanApprover = new LoanApprover();

            //Person-1
            Person bob = new Person("Bob", 5000, true);
            string approvalStatus = loanApprover.CheckLoanEligibility(bob, 20000);
            Console.WriteLine($"{bob.name}'s application status:{approvalStatus}");

            //Person-2
            Person jack = new Person("Jack");
            approvalStatus = loanApprover.CheckLoanEligibility(jack, 30000);
            Console.WriteLine($"{jack.name}'s application status: {approvalStatus}");

            //Person-3
            Person tony = new Person("Tony", 125000, true);
            approvalStatus = loanApprover.CheckLoanEligibility(tony, 50000);
            Console.WriteLine($"{tony.name}'s application status: {approvalStatus}");

            ////Person-4
            //Person kate = new Person("Kate", 70000);
            //approvalStatus = loanApprover.CheckLoanEligibility(kate, 70000);
            //Console.WriteLine($"{kate.name}'s application status: {approvalStatus}");


            Console.ReadKey();
        }
    }
}
