using System;

class Program {
    static void Main() {

        string again = "a";

        while(again=="a") { 
            razitko();
            ulong a = nacistCislo("Zadejte číslo a: ");
            ulong b = nacistCislo("Zadejte číslo b: ");

            ulong nsd = vypocitatNSD(a, b);
            ulong nsn = vypocitatNSN(a, b, nsd);

            zobrazitVysledky(a, b,nsd, nsn);

        

            Console.WriteLine();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();       

        }
static void razitko(){
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*******************"); 
            Console.WriteLine("**** NSD a NSN ****");  
            Console.WriteLine("*******************"); 
            Console.WriteLine("* Vojtěch Macháček ");   
            Console.WriteLine("*******************"); 
            Console.WriteLine();


}

static ulong nacistCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
            Console.Write("Nebylo zadáno přirozené číslo!!! Zadejte znovu: ");
            }
    return cislo;
}

static ulong vypocitatNSD(ulong x, ulong y){  //může být a i b ale jsou to jiné hodnoty než nahoře a platí jen pro tu metodu
    while(x != y){
        if(x>y){
            x = x -y;
        }
        else
            y = y - x;
    }

return x;
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd){
    return(a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nNSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;

}



    }
}