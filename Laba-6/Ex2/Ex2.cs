using System;

class Ex2
{
    static void Main()
    {
        Console.Write("Author: ");
        string? author = Console.ReadLine();

        Console.Write("Title: ");
        string? title = Console.ReadLine();

        Console.Write("Price: ");
        float? price = Convert.ToSingle(Console.ReadLine());


        Book book = new(title, author, price);
        Console.WriteLine("\n" + book + "\n");


        GoldenEditionBook goldenEditionBook = new(book.Title, book.Author, book.Price);
        Console.WriteLine(goldenEditionBook);


        Console.ReadKey();
    }
}