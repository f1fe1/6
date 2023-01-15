using System;
using System.Globalization;
using System.Text;

class Book
{
    protected string? title;
    protected string? author;
    protected float? price;

    public string? Title 
    { 
        get => title; 
        set 
        {
            while (value?.Length < 3)
            {
                Console.Write("\nTitle not valid!\nTitle: ");
                value = Console.ReadLine();
            }
            title = value; 
        } 
    }
    public string? Author
    {
        get => author;
        set
        {
            while (!CheckToDigitAuthor(value))
            {
                Console.Write("\nAuthor not valid!\nAuthor: ");
                value = Console.ReadLine();
            }
            author = value;
        }
    }
    public float? Price
    {
        get => price;
        set
        {
            while (value < 0)
            {
                Console.Write("\nPrice not valid!\nPrice: ");
                value = Convert.ToSingle(Console.ReadLine());
            }
            price = value;
        }
    }

    // Перевірка, чи починається ім'я автора з цифри
    static bool CheckToDigitAuthor (string? str)
    {
        if (str == null) return false;

        if (str != null)
            for (int i = 0; i < str.Length; i++)
                if ((char.IsDigit(str[i]) && i == 0) || (char.IsDigit(str[i]) && str[i - 1] == ' '))
                    return false;

        return true;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(String.Format("Type: Book \nTitle: {0} \nAuthor: {1} \nPrice: {2:0.00}", this.Title, this.Author, this.Price));

        return stringBuilder.ToString();
    }

    public Book(string? title, string? author, float? price) 
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }
}