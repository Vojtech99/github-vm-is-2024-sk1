using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string again = "a";
        
        while (again == "a")
        {
            
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor Fibonacciho posloupnosti *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Vojtěch Macháček **************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.Write("Zadejte počet členů Fibonacciho posloupnosti (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nezadali jste platné celé číslo. Zadejte počet členů znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet členů: {0}", n);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Stopwatch stopwatch = Stopwatch.StartNew();
            ulong[] fibonacciArray = GenerateFibonacci(n);
            stopwatch.Stop();
            
            ulong sum = 0;
            foreach (ulong num in fibonacciArray)
            {
                Console.Write("{0}; ", num); 
                sum += num;
            }
            
            Console.WriteLine();
            Console.WriteLine("{0}. prvek Fibonacciho posloupnosti je: {1}", n, fibonacciArray[n - 1]);
            Console.WriteLine("Součet posloupnosti (do {0} členu): {1}", n, sum); 
            Console.WriteLine("Čas trvání výpočtu: {0}", stopwatch.Elapsed);

            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine().ToLower();
        }
    }

    static ulong[] GenerateFibonacci(int n)
    {
        ulong[] fibonacci = new ulong[n];
        if (n >= 1) fibonacci[0] = 0; 
        if (n >= 2) fibonacci[1] = 1; 

        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return fibonacci;
    }
}