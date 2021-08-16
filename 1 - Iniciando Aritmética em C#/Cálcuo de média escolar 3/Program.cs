using System;
using System.Globalization;

namespace Cálcuo_de_média_escolar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);
            d = double.Parse(values[3], CultureInfo.InvariantCulture);

            avg = ((a * 2) + (b * 3) + (c * 4) + (d * 1)) / 10;

            Console.WriteLine("Media: " + avg.ToString("0.0"));

            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (avg >= 5 && avg <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
                
                avg = (avg + e) / 2;
                
                if (avg >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + avg.ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}