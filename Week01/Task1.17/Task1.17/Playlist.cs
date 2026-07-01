using System;

namespace Task1_17
{
    public class Playlist
    {
        private string[] songs =
        {
            "Believer",
            "Shape of You",
            "Perfect"
        };

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < songs.Length)
                    return songs[index];

                return "Invalid Index";
            }

            set
            {
                if (index >= 0 && index < songs.Length)
                    songs[index] = value;
            }
        }

        public string this[string songName]
        {
            get
            {
                foreach (string song in songs)
                {
                    if (song.Equals(songName, StringComparison.OrdinalIgnoreCase))
                        return song;
                }

                return "Song Not Found";
            }
        }
    }
}