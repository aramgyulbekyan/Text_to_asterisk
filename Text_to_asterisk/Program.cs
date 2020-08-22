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
           
            //version with user input 

            /*Console.WriteLine("please input name");
            string name = Console.ReadLine();
            writer.WriteConsole(name, settings);*/

            // version for homework
            writer.WriteConsole("ARAM", settings);
        }
    }
}
