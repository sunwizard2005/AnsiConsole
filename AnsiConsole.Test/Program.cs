
using System;
using System.Drawing;

namespace AnsiConsole.Test
{
    class Program
    {
        public static void Main(string[] args)
        {
           AnsiConsole.Console.WriteLine($"[red]Hello, [fg:0:FF:00]World[red]![normal]");
        }
    }
}
