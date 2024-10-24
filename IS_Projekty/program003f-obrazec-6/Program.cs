string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("*********************"); 
            Console.WriteLine("**** Obrazec - 6 ****");  
            Console.WriteLine("*********************"); 
            Console.WriteLine("** Vojtěch Macháček *");   
            Console.WriteLine("*********************"); 
            Console.WriteLine();

                Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
            }

            for(int i = 0; i <=height; i++){
                for(int j = 0; j <= height; j++){
                  
                 if(j == 0){
                    Console.Write("*");
                   }
                   else if (j == height){
                    Console.Write("*");
                   }
                    else if (i == j){
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