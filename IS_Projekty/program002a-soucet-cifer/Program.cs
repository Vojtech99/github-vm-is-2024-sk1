string again = "a";

        while(again=="a") { 
            Console.Clear();
            Console.WriteLine("*********************************"); 
            Console.WriteLine("**** Ciferný součet a součin ****");  
            Console.WriteLine("*********************************"); 
            Console.WriteLine("******** Vojtěch Macháček *******");   
            Console.WriteLine("*********************************"); 
            Console.WriteLine();



             Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");

            }

            int suma = 0;
            int numberBackup = number;
            int digit;
            int soucin = 1;

            if(number<0)
                number = - number;

            while(number >= 10) {
                digit = number % 10;
                number = (number-digit)/10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                soucin = soucin * digit;
            }

             Console.WriteLine("Digit = {0}", number);

             //musíme přičíst ještě poslední cifru
             suma = suma + number;

             //musíme ještě donásobit poslední cifru
             soucin = soucin * number;

            Console.WriteLine();
            Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);

            Console.WriteLine();
            Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, soucin);



        

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();     


        }

         
