using System;

class Program {
    static void Main() {
        string again = "a";

        while(again == "a") { 
            Console.Clear();
            Console.WriteLine("*********************************"); 
            Console.WriteLine("**** Aritmetická posloupnost ****");  
            Console.WriteLine("*********************************"); 
            Console.WriteLine("******** Vojtěch Macháček *******");   
            Console.WriteLine("*********************************"); 
            Console.WriteLine();

            
            Console.Write("Zadejte počet čísel: ");
            int pocetCisel;
            while (!int.TryParse(Console.ReadLine(), out pocetCisel) || pocetCisel <= 0) {
                Console.Write("Nezadali jste platné celé číslo. Zadejte počet čísel znovu: ");
            }

            Console.Write("Zadejte diferenci: ");
            int diference;
            while (!int.TryParse(Console.ReadLine(), out diference)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
            }

            Console.Write("Zadejte první prvek posloupnosti: ");
            int prvniPrvek;
            while (!int.TryParse(Console.ReadLine(), out prvniPrvek)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první prvek znovu: ");
            }

            
            int soucet = 0;

            
            Console.WriteLine("\nAritmetická posloupnost:");
            for (int i = 0; i < pocetCisel; i++) {
                
                int prvek = prvniPrvek + i * diference;
                Console.Write(prvek + " ");
                soucet += prvek; 
            }

            Console.WriteLine("\nSoučet zobrazených čísel: " + soucet);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine(); 
        }
    }
}