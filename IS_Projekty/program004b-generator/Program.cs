using System.ComponentModel;
using System.Formats.Asn1;



string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("*****************************************"); 
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");  
            Console.WriteLine("*****************************************"); 
            Console.WriteLine("************ Vojtěch Macháček ***********");   
            Console.WriteLine("*****************************************"); 
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
            




            //deklarace pole
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            int zaporne= 0;
            int kladne = 0;
            int nuly =0;
            int sude=0;
            int liche=0;

            Console.WriteLine("\n\nNáhodná čísla");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);

                // if(myArray[i] < 0)
                //     zaporne++;
                // if (myArray[i] > 0)
                //     kladne++;
                // if(myArray[i] == 0)
                //     nuly++;

                //kladná a záporná

                if(myArray[i]>0)
                    kladne++;
                else if(myArray[i]<0)
                    zaporne++;
                else
                    nuly++;

                
                //sudá a lichá
                if(myArray[i]%2==0)
                    sude++;
                else
                    liche++;



            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Počet kladných čísel: {0}", kladne);
            Console.WriteLine("Počet záporných čísel: {0}", zaporne);
            Console.WriteLine("Počet nul: {0}", nuly);
            Console.WriteLine("Počet sudých čísel: {0}", sude);
            Console.WriteLine("Počet lichých čísel: {0}", liche);



          


            

            
               









        

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       

        }

