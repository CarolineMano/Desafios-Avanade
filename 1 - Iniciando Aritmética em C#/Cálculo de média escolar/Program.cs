using System;
using System.Globalization;

namespace Cálculo_de_média_escolar
{
    class Program
    {
        static void Main(string[] args) 
        { 

            double a, b, mediaP;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            mediaP = ((a* 3.5) + (b* 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));

        }
    }
}
