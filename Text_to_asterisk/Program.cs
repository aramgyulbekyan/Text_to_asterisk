using System;
using TextToAsciiArt;

namespace Text_to_asterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            IArtWriter writer = new ArtWriter();
            var settings = new ArtSetting
            {
                ConsoleSpeed = 50, // Console write speed , the lower value gives moree speed
                Text = "*",  // text symbol
                BgText = " "  // background symbol
            };
            writer.WriteConsole("ARAM", settings);


        }
    }
}
