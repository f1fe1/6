using System;

class Ex4
{
    static void Main()
    {
        Console.Write("Number of songs: ");
        int? num = Convert.ToInt32(Console.ReadLine());

        OnlineRadioDatabase onlineRadioDatabase = new((int)num);


        Console.WriteLine();
        onlineRadioDatabase.InputSongs(num);

        Console.WriteLine();
        onlineRadioDatabase.OutputNumberOfSongsAddedAndTimeSongs(num);


        Console.ReadKey();
    }
}