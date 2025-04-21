using System;

class Program
{
    static void Main(string[] args)
    {
        string name1, name2;

        Console.Write("Enter First Name: ");
        name1 = Console.ReadLine();

        Console.Write("Enter Middle Name: ");
        name2 = Console.ReadLine();

        ShowNames(name1, name2);
    }

    static void ShowNames(string n1, string n2)
    {
    Console.WriteLine("\nHere are the names yoy entered:");
    Console.WriteLine("First Name: " + n1);
    Console.WriteLine("Middle Name: " + n2);
    }

}
