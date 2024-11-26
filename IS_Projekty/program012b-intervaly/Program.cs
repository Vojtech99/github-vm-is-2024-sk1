using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********************");
            Console.WriteLine("***** Intervaly *****");
            Console.WriteLine("*********************");
            Console.WriteLine("* Vojtěch Macháček **");
            Console.WriteLine("*********************");
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }
            Console.Write("Zadejte počet intervalů: ");
            int pocetIntervalu;
            while (!int.TryParse(Console.ReadLine(), out pocetIntervalu) || pocetIntervalu <= 0)
            {
                Console.Write("Nezadali jste platné celé číslo. Zadejte počet intervalů znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}; počet intervalů: {3}", n, dm, hm, pocetIntervalu);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            
            int[] myArray = new int[n];
            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }

            
            int[] intervalCounts = new int[pocetIntervalu];
            double intervalWidth = (double)(hm - dm) / pocetIntervalu;

            for (int i = 0; i < n; i++)
            {
                int index = (int)((myArray[i] - dm) / intervalWidth);
                if (index >= pocetIntervalu) index = pocetIntervalu - 1; 
                intervalCounts[index]++;
            }

           
            for (int i = 0; i < pocetIntervalu; i++)
            {
                double lowerBound = dm + i * intervalWidth;
                double upperBound = dm + (i + 1) * intervalWidth;
                Console.WriteLine("");
                Console.WriteLine("\nInterval <{0}, {1}>: {2}", lowerBound, upperBound, intervalCounts[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
    }
}