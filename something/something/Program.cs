using OPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();
            Rectangle firstRect = new Rectangle(width, height, color);
            Console.WriteLine($"Rect({firstRect.Width}, {firstRect.Height}, {firstRect.Color}) has area {firstRect.CalcArea()}.");
        }
    }
}