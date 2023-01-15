using System;

class MoodFactory : Person
{
    string? mood;
    string? importance = "0";

    public override string? Importance { get => importance; set => importance = value; }
    public string? Mood { get => mood; set => mood = value; }


    public override void Filling() { }
    public override void Filling(string? []ImportanceFood)
    {
        for(int i = 0; i < ImportanceFood.Length; i++)
        {
            switch(ImportanceFood[i]?.ToLower())
            {
                case "cram":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) + 2);
                    break;
                case "lembas":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) + 3);
                    break;
                case "apple":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) + 1);
                    break;
                case "melon":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) + 1);
                    break;
                case "honeyCake":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) + 5);
                    break;
                case "mushrooms":
                    Importance = Convert.ToString(Convert.ToInt32(Importance) - 10);
                    break;
                default:
                    Importance = Convert.ToString(Convert.ToInt32(Importance) - 1);
                    break;
            }
        }
    }

    public void OutputMood()
    {
        switch(Convert.ToInt32(Importance))
        {
            case < -5:
                Console.WriteLine("{0}\nAngry", Importance);
                break;
            case <= 0:
                Console.WriteLine("{0}\nSad", Importance);
                break;
            case <= 15:
                Console.WriteLine("{0}\nHappy", Importance);
                break;
            case > 15:
                Console.WriteLine("{0}\nJavaScript", Importance);
                break;
        }
    }

    public MoodFactory() { }
}
