string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("***************************"); 
            Console.WriteLine("**** Maximum a minimum ****");  
            Console.WriteLine("***************************"); 
            Console.WriteLine("***** Vojtěch Macháček ****");   
            Console.WriteLine("***************************"); 
            Console.WriteLine();


             Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
            Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

              Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte zadejte dolní mez znovu: ");
            }

              Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("Zadejte hodnoty");
            Console.WriteLine("Počet čísel: {0}; dolní mez {1}, horní mez: {2}", n,dm,hm);
            Console.WriteLine("=======================================");
            Console.WriteLine();
            


            int[] myArray = new int[n];

            Random randomNumber = new Random();


            Console.WriteLine("\n\nNáhodná čísla");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);   


            }

            int max = myArray[0];
            int min = myArray[0];
            List<int> poziceMin = new List<int>();
            List<int> poziceMax = new List<int>();
            int pocetMax = 0;
            int pocetMin = 0;
           
            for(int i = 1; i < n; i++){
                 if(myArray[i] == max){
                    pocetMax++;
                }
                  if(myArray[i] == min){
                    pocetMin++;
                }
                if(myArray[i]>max){
                    max = myArray[i];
                    poziceMax.Clear();
                    poziceMax.Add(i);
                    pocetMax = 1;
                }
                else if (myArray[i] == max){
                    poziceMax.Add(i);
                }
            
             
                if(myArray[i]<min){
                    min = myArray[i];
                    poziceMin.Clear();
                    poziceMin.Add(i);
                    pocetMin = 1;
                }
                else if (myArray[i] == min){
                    poziceMin.Add(i);
                }
                
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Počet maximálních hodnot = {0}", pocetMax);
            Console.WriteLine("Počet minimalních hodnot = {0}", pocetMin);
            Console.WriteLine();
            Console.WriteLine($"Maximum = {max}; jeho pozice v poli: {string.Join(", ", poziceMax)}");
            Console.WriteLine($"Minimum = {min}; jeho pozice v poli: {string.Join(", ", poziceMin)}");
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       

        }
