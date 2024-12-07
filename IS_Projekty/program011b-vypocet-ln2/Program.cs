string again = "a";

while (again == "a") 
{ 
    Console.Clear();
    Console.WriteLine("****************************"); 
    Console.WriteLine("**** Výpočet ln(2) ****");  
    Console.WriteLine("****************************"); 
    Console.WriteLine("**** Vojtěch Macháček ****");   
    Console.WriteLine("****************************"); 
    Console.WriteLine();

    Console.Write("Zadejte přesnost (reálné číslo - čím menší hodnota, tím bude výpočet přesnější): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost)) 
    {
        Console.Write("Nezadali jste reálné číslo. Zadejte přesnost znovu: ");
    }

    double ln2 = 0;
    double n = 1; 
    double zlomek;
    double znamenko = 1; 

    while (Math.Abs(1/n) > presnost) 
    {
        zlomek = znamenko / n; 
        ln2 += zlomek; 
        znamenko = -znamenko; 

        Console.WriteLine("Zlomek: {0}, aktuální hodnota ln(2) = {1}", zlomek, ln2);
        n++; 
    }

    Console.WriteLine("\n\nHodnota přirozeného logaritmu čísla 2 = {0}", ln2);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu A");
    again = Console.ReadLine(); 
}