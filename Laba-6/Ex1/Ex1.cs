using System;

class Ex1
{
    static void Main()
    {

        string? temp = "";

        while (temp?.ToLower() != "end")
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.Write("Age: ");
            int? age = Convert.ToInt32(Console.ReadLine());



            Child child = new(name, age);
            Console.WriteLine(child);

            temp = Console.ReadLine();
        }


        Console.ReadKey();
    }
}