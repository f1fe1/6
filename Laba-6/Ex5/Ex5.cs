using System;

class Ex5
{
    static void Main()
    {
        string? temp = Console.ReadLine();


        FoodFactory foodFactory = new(temp);
        foodFactory.Filling();

        MoodFactory moodFactory = new();
        moodFactory.Filling(foodFactory.Food);
        moodFactory.OutputMood();


        Console.ReadKey();
    }
}