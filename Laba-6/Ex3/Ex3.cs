using System;

class Ex3
{
    static void Main()
    {
        Student student = new("Stefo", "Mk321", "0812111");
        Console.WriteLine(student + "\n");

        Worker worker = new("Ivcho", "Ivancov", 1590, 10);
        Console.WriteLine(worker);


        Console.ReadKey();
    }
}