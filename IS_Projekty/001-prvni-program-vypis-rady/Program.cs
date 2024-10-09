using System;
using System.Runtime.ExceptionServices;

class Program {
    static void Main() {

        string again = "a";

        while(again=="a") { //dve rovnáse jsou porovnání
            Console.Clear();
            Console.WriteLine("**************************"); 
            Console.WriteLine("**** Výpis řady čísel ****");  
            Console.WriteLine("**************************"); 
            Console.WriteLine("**** Vojtěch Macháček ****");   
            Console.WriteLine("**************************"); 
            Console.WriteLine();

            //Vstup hodnot do programu - špatně řešený
           // Console.Write("Zadejte první číslo řady: ");
            //int first =int.Parse(Console.ReadLine()); 

            //vstup hodnot do programu -správně řešení
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");

            }

             Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
            Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");

            }

             Console.Write("Zadejte diferenci (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");

            }

            //Výpis řady
            Console.WriteLine("");
            Console.WriteLine("==================");
            Console.WriteLine("Výpis číselné řady");
            int current = first;
            while(current <= last){
                Console.WriteLine(current);
                current = current + step; //ruční přičtení diference
            }


            //výpis zadaných hodnot
            Console.WriteLine();
            Console.WriteLine("Zadali jste tyto hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       //jedno rovnáse je přikázání


        }



    }
}


//toto je jednořádový komentář

/* toto je
víceřádkový 
komentář */

// tab = posun řádku , shift+tab posun na druhou stranu






