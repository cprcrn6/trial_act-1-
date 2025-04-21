string surname;

Console.Write("Enter surname: ");
name3 = Console.ReadLine();

ShowNames(name1, middle, surname);


static void ShowNames(string n1, string n2, string sn)
{
    Console.WriteLine("\nYou entered:");
    Console.WriteLine("First Name: " + n1);
    Console.WriteLine("Middle Name: " + mid);
    Console.WriteLine("SurName: " + sn);
}
