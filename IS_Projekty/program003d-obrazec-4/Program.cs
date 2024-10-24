string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("*********************"); 
            Console.WriteLine("**** Obrazec - 4 ****");  
            Console.WriteLine("*********************"); 
            Console.WriteLine("** Vojtěch Macháček *");   
            Console.WriteLine("*********************"); 
            Console.WriteLine();

            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
            }

           for (int i = 0; i < height; i++) {
                for (int j = 0; j < height; j++){
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                
                if (i == 0 || i == height - 1 || i + j == height - 1) {
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            
            Console.WriteLine("");
        }
            

        

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();      


        }