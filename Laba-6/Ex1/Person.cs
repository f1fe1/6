using System;
using System.Text;

class Person
{
    protected string? name;
    protected int? age;

    public string? Name 
    { 
        get => name; 
        set 
        {
            if (value?.Length < 3) Console.WriteLine("Name's length should not be less than 3 symbols!");
            name = value;
        } 
    }
    public int? Age 
    { 
        get => age; 
        set
        {
            while (value < 0 || value > 15)
            {
                if (value < 0) Console.WriteLine("Age must be positive!");
                else if (value > 15) Console.WriteLine("Child's age must be less than 15!");
                value = Convert.ToInt32(Console.ReadLine());
            }

            age = value;
        } 
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(String.Format("Name: {0}, Age: {1}",  this.Name,  this.Age));

        return stringBuilder.ToString();
    }


    public Person(string? name, int? age)
    {
        Name = name;
        Age = age;
    }
}
