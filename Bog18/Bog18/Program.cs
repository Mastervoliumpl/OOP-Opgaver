using System;
using System.Timers;

namespace Bog18
{
    class Program
    {
        static void Main()
        {
            var timer = new System.Timers.Timer(5000) 
            { 
                AutoReset = true, 
                Enabled = true 
            };

            ConsoleColor[] farver = new[]
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan
            };

            timer.Elapsed += (sender, e) =>
            {
                var farveIndex = (DateTime.Now.Second / 5) % farver.Length;
                Console.BackgroundColor = farver[farveIndex];
                Console.Clear();
            };

            Console.WriteLine("Tryk 'Enter' for at afslutte programmet.");
            Console.ReadLine();
        }
    }
}
