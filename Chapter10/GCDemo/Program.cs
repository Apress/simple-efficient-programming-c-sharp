using System;


namespace GCDemo
{
    class Sample
    {
        public Sample()
        {
            //Some code            
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Exploring Garbage Collections.***");
            try
            {
                Console.WriteLine($"Maximum GC Generation is {GC.MaxGeneration}");
                Sample sample = new Sample();
                CheckObjectStatus(sample);

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\n After GC.Collect({i})");
                    //GC.Collect(i,GCCollectionMode.Forced,true,true);
                    GC.Collect(i, GCCollectionMode.Forced, false, true);
                    System.Threading.Thread.Sleep(5000);
                    GC.WaitForPendingFinalizers();
                    ShowAllocationStatus();
                    CheckObjectStatus(sample);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadKey();
        }

        private static void CheckObjectStatus(Sample sample)
        {
            if (sample is not null) //C# 9.0 onwards
            {
                Console.WriteLine($" The {sample} object is in Generation:{GC.GetGeneration(sample)}");
            }
        }

        private static void ShowAllocationStatus()
        {
            Console.WriteLine("---------");
            Console.WriteLine($"Gen-0 collection count:{GC.CollectionCount(0)}");
            Console.WriteLine($"Gen-1 collection count:{GC.CollectionCount(1)}");
            Console.WriteLine($"Gen-2 collection count:{GC.CollectionCount(2)}");
            Console.WriteLine($"Total Memory allocation:{GC.GetTotalMemory(false)}");
            Console.WriteLine("---------");
        }
    }
}



