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
                ConsoleSpeed = 100,
                IsBreakSpace = true,
                Text = "*",
                BgText = " "
            };
            writer.WriteConsole("ARAM", settings);


        }
    }
}
