using System;

class FoodFactory : Person
{
    string?[] food = new string?[1000];
    string? importance;


    public string?[] Food { get => food; set => food = value; }

    public override string? Importance 
    {
        get => importance;
        set
        {
            if (value?.Length > 1000)
                Console.WriteLine("The number of characters must be no more than [1000]");

            importance = value;
        }
    }

    public override void Filling(string?[] obj) { }
    public override void Filling()
    {
        if (Importance != null)
        {
            int index = 1;


            for (int i = 0; i < Importance.Length; i++) 
                if (Importance[i] == ' ') 
                    index++;


            if (index > 100 || index < 1)
                Console.WriteLine("The food count must be in the range [1…100]");

            Food = new string?[index];

            index = 0;


            for (int i = 0; i < Importance.Length; i++)
                if (Importance[i] != ' ')
                    Food[index] += Importance[i];
                else if (Importance[i] == ' ')
                    index++;
        }
    }


    public FoodFactory(string? importance) 
    {
        Importance = importance;
    }
}