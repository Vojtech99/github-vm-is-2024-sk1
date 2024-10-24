string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("********************************"); 
            Console.WriteLine("***** Pravoúhlý trojuhelník ****");  
            Console.WriteLine("********************************"); 
            Console.WriteLine("******* Vojtěch Macháček *******");   
            Console.WriteLine("********************************"); 
            Console.WriteLine();





               Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");

            }

        


            for (int i = 1; i <= height; i++) {
                for (int j = 1; j <= i; j++){
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    Console.Write("* ");
            }
            Console.WriteLine();
        }

        


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       


        }
