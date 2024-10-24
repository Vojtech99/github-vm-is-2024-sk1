
        string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("******************************"); 
            Console.WriteLine("**** Obrazec - Písmenko V ****");  
            Console.WriteLine("******************************"); 
            Console.WriteLine("****** Vojtěch Macháček ******");   
            Console.WriteLine("******************************"); 
            Console.WriteLine();

            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
            }



             for (int i = 0; i < height; i++) {
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                for (int j = 0; j < i; j++){
                Console.Write(" ");
            }
             Console.Write("*");

            for (int j = 0; j < (2* (height - i -1)); j++){
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                
                Console.Write(" ");
            }

            if (i != height ){ 
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    


        

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       


        }

