using System;

class Program
{
    static void Main(string[] args)
    {
        string name1, name2;

        Console.Write("Enter First Name: ");
        name1 = Console.ReadLine();

        Console.Write("Enter Second Name: ");
        name2 = Console.ReadLine();

        ShowNames(name1, name2);
    }

    static void ShowNames(string n1, string n2)
    {
    Console.WriteLine("\nYou entered:");
    Console.WriteLine("Name 1: " + n1);
    Console.WriteLine("Name 2: " + n2);
    }

}
