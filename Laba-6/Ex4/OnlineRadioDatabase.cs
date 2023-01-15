using System;
class OnlineRadioDatabase
{
    int? numberOfSongs = 0;

    public int? NumberOfSongs { get => numberOfSongs;  set => numberOfSongs = value; }

    readonly Song[] songs = Array.Empty<Song>();

    
    public void InputSongs(int? size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("Artist name: ");
            string? tempArtistName = Console.ReadLine();

            Console.Write("Song name: ");
            string? tempSongName = Console.ReadLine();

            Console.Write("Legth song [min:sec]: ");
            string? tempMinutesSeconds = Console.ReadLine();

            songs[i] = new(tempArtistName, tempSongName, tempMinutesSeconds);
            if (songs[i].InvalidSongException(tempArtistName, tempSongName, tempMinutesSeconds))
            {
                Console.WriteLine("Song added.");
                NumberOfSongs++;
            }

            Console.WriteLine();
        }

    }

    public void OutputNumberOfSongsAddedAndTimeSongs(int? size)
    {
        Console.WriteLine("Songs added: {0}", NumberOfSongs);
        Console.WriteLine("Playlist length: {0}", CalculateAllTimeSongs(size));
    }

    string CalculateAllTimeSongs(int? size)
    {
        int hr = 0;
        int min = 0;
        int sec = 0;


        for (int i = 0; i < size; i++)
            if (songs[i].InvalidSongException(songs[i].ArtistName, songs[i].SongName, songs[i].MinutesSeconds))
            {
                sec += Convert.ToInt32(songs[i].CaltulateSongSeconds());
                min += Convert.ToInt32(songs[i].CaltulateSongMinutes());


                min += sec / 60;
                sec = sec > 59 ? sec - 60 : sec;
                hr += min / 60;
                min = min > 59 ? min - 60 : min;
            }


        return $"{hr}h {min}m {sec}s";
    }


    

    public OnlineRadioDatabase(int numberOfSongs)
    {

        if (NumberOfSongs != null)
            songs = new Song[(int)numberOfSongs];
    }
}
