using System;
using System.Globalization;

namespace Consumo_Medio_do_Automovel
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distancia/combustivelGasto; 

            Console.WriteLine("{0:0.000} km/l", consumoMedio);

        }
    }
}
