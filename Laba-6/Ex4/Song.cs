using System;
using System.Reflection;

class Song
{
    string? artistName;
    string? songName;
    string? minutesSeconds;

    public string? ArtistName 
    {
        get => artistName; 
        set
        {
            if (!InvalidArtistNameException(value))
                Console.WriteLine("Artist name should be between 3 and 20 symbols");

            artistName = value;
        }
    }
    public string? SongName 
    {
        get => songName;
        set
        {
            if (!InvalidSongNameException(value))
                Console.WriteLine("Song name should be between 3 and 30 symbols");

            songName = value;
        }
    }
    public string? MinutesSeconds 
    {
        get => minutesSeconds;
        set
        {
            if (!InvalidSongMinutesException(value))
                Console.WriteLine("Song minutes should be between 0 and 14.");
            
            if (!InvalidSongSecondsException(value))
                Console.WriteLine("Song seconds should be between 0 and 59.");


            minutesSeconds = value;
        }
    }

    public string CaltulateSongMinutes()
    {
        string? temp = "";

        for (int i = 0; i < MinutesSeconds?.Length; i++)
            if (MinutesSeconds[i] == ':') break;
            else temp += MinutesSeconds[i];


        return temp;
    }

    public string CaltulateSongSeconds()
    {
        string? temp = "";
        int index = 0;


        for (int i = 0; i < MinutesSeconds?.Length; i++)
            if (MinutesSeconds[i] == ':') { index = i; break; }

        for (int i = index + 1; i < MinutesSeconds?.Length; i++)
            temp += MinutesSeconds[i];


        return temp;
    }

    static bool InvalidSongMinutesException(string? min)
    {
        string? temp = "";

        for (int i = 0; i < min?.Length; i++)
            if (min[i] == ':') break;
            else temp += min[i];

        if (Convert.ToInt32(temp) < 0 || Convert.ToInt32(temp) > 14)
            return false;


        return true;
    }

    static bool InvalidSongSecondsException(string? sec)
    {
        string? temp = "";
        int index = 0;


        for (int i = 0; i < sec?.Length; i++)
            if (sec[i] == ':') { index = i; break; }

        for (int i = index + 1; i < sec?.Length; i++) 
            temp += sec[i];


        if (Convert.ToInt32(temp) < 0 || Convert.ToInt32(temp) > 59)
            return false;


        return true;
    }

    static bool InvalidSongLengthException(string? length) => 
        InvalidSongMinutesException(length) && InvalidSongSecondsException(length) == true;

    static bool InvalidSongNameException(string? songName) => songName?.Length >= 3 && songName?.Length <= 30;

    static bool InvalidArtistNameException(string? artistName) => artistName?.Length >= 3 && artistName?.Length <= 20;

    public bool InvalidSongException(string? artistName, string? songName, string? minutesSeconds) =>
        InvalidSongLengthException(minutesSeconds) && InvalidSongNameException(songName) && InvalidArtistNameException(artistName);


    public Song(string? artistName, string? songName, string? minutesSeconds)
    {
        ArtistName = artistName;
        SongName = songName;
        MinutesSeconds = minutesSeconds;
    }
}
