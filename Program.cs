using System;

class Program
{
    static void Main(string[] args)
    {
        string name1, middle;

        Console.Write("Enter First Name: ");
        name1 = Console.ReadLine();

        Console.Write("Enter Middle Name: ");
        name2 = Console.ReadLine();

        ShowNames(name1, middle);
    }

    static void ShowNames(string n1, string mid2)
    {
    Console.WriteLine("\nHere are the names you entered:");
    Console.WriteLine("First Name: " + n1);
    Console.WriteLine("Middle Name: " + mid2);
    }

}
