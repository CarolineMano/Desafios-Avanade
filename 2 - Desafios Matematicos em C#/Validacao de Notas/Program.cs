using System;
using System.Globalization;

namespace Validacao_de_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, media = 0;
            int opcao = 1, contadorNotas = 0;
            bool validacaoOpcao = false;

            while(opcao == 1)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                } 
                else if (nota >= 0 && nota <= 10) 
                {
                    media += nota;
                    contadorNotas++;
                }
                if (contadorNotas == 2)
                {
                    media /= 2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));
                    media = 0;
                    validacaoOpcao = false;
                }

                while (!validacaoOpcao && contadorNotas == 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());

                    if(opcao != 1 && opcao != 2)
                    {
                        validacaoOpcao = false;
                    }
                    else
                    {
                        validacaoOpcao = true;
                        contadorNotas = 0;
                    }
                }                
            }
        }
    }
}


// using System;

// class Desafio {
//     static void Main() {
//     //declare suas variaveis corretamente


//         //continue a solução ou implemente da sua maneira

//         while (             ) {
        
//           if (                  ) {
//             Console.WriteLine("nota invalida");
//           } else if (   ) {
           
//           } else if (  ) {
            

//             Console.Write("media = ");
//             Console.WriteLine(media.ToString("N2"));
            
//             while (                 ){
//               Console.WriteLine("novo calculo (1-sim 2-nao)");
//               double res = double.Parse(Console.ReadLine());
	
//               if (              ) {
              
//               } else if (     ) {
                                 
//               }
//             }
//           } 
//         }
//     }
// }