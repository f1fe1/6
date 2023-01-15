using System;
using System.Text;

class Human
{
    string? firstName;
    string? lastName;

    public string? FirstName 
    { 
        get => firstName;
        set 
        {
            while (value?.Length <= 3 || value == null || value[0] != char.ToUpper(value[0]))
            {
                if (value != null && value[0] != char.ToUpper(value[0]))
                    Console.Write("Expected upper case letter! Argument: {0}\nFirst name: ", value);
                else if (value?.Length <= 3 || value == null)
                    Console.Write("Expected length at least 4 symbols! Argument: {0}\nFirst name: ", value);

                value = Console.ReadLine();
            }

            firstName = value; 
        } 
    }
    public string? LastName 
    { 
        get => lastName; 
        set
        {
            while (value?.Length < 3 || value == null || value[0] != char.ToUpper(value[0]))
            {
                if (value != null && value[0] != char.ToUpper(value[0]))
                    Console.Write("Expected upper case letter! Argument: {0}\nLast Name: ", value);
                else if (value?.Length <= 3 || value == null)
                    Console.Write("Expected length at least 3 symbols! Argument: {0}\nLast Name: ", value);

                value = Console.ReadLine();
            }

            lastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append(String.Format("Fist Name: {0}\nLast Name: {1}", FirstName, LastName));


        return stringBuilder.ToString();
    }

    public Human(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
