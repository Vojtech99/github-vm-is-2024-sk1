﻿using System;

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

                Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
            }

        

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






