using System;

namespace HW_13
{
    class Song
    {
        private string _title;
        private uint _duration;
        private string _author;
        private uint _yearMade;

        internal static Song GetSongInstance()
        {
            throw new NotImplementedException();
        }

        private MusicGen _genre;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public uint Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public uint YearMade
        {
            get { return _yearMade; }
            set { _yearMade = value; }
        }

        public MusicGen Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public Song(string title, uint duration, string author, uint yearMade, MusicGen genre)
        {
            Title = title;
            Duration = duration;
            Author = author;
            YearMade = yearMade;
            Genre = genre;
        }
        public static dynamic GetSongData(Song song)
        {
            string songGenre = song.Genre.ToString();
            return new { song.Title, song.Duration, song.Author, song.YearMade, songGenre };
        }
    }
}