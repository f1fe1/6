using System;
using System.Text;

class GoldenEditionBook : Book
{
    public new string? Title { get => title; set => title = value; }
    public new string? Author { get => author; set => author = value; }
    public new float? Price { get => price * (float)1.3; set => price = value; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format("Type: GoldenEditionBook \nTitle: {0} \nAuthor: {1} \nPrice: {2:0.00}", Title, Author, Price));

        return stringBuilder.ToString();
    }

    public GoldenEditionBook(string? title, string? author, float? price)
        : base(title, author, price)
    {
    }
}
