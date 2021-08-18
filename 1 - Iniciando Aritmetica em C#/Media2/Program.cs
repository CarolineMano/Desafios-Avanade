using System;
using System.Globalization;

namespace Media2
{
    class Program
    {
        static void Main(string[] args) 
        { 

            double a, b, c, mediaP;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            mediaP = (a * 0.2) + (b * 0.3) + (c * 0.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.0"));

        }
    }
}
