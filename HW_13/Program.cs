using Newtonsoft.Json;
using System;

namespace HW_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var songInfo = Song.GetSongData(song: Song.GetSongInstance());
            Console.WriteLine(JsonConvert.SerializeObject(songInfo, Formatting.Indented));
        }
    }
}