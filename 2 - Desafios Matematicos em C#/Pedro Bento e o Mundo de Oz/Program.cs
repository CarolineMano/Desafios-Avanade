using System;
using System.Collections.Generic;

namespace Pedro_Bento_e_o_Mundo_de_Oz
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoJoia;
            bool testeTipo = false;
            int tamanhoMaximo = 0;
            List<string> tesouro = new List<string>();

            do
            {
                tipoJoia = Console.ReadLine();
                if(!string.IsNullOrEmpty(tipoJoia))
                {
                    tamanhoMaximo += tipoJoia.Length;
                    if(tesouro.Count == 0)
                        testeTipo = true;

                    else 
                    {
                        foreach(var item in tesouro)
                        {
                            if(item == tipoJoia)
                            {
                                testeTipo = false;
                                break;
                            }     
                        }
                    }  

                    if (testeTipo)
                    {
                        tesouro.Add(tipoJoia);
                    }
                    testeTipo = true;
                }
            } while (!string.IsNullOrEmpty(tipoJoia) && tamanhoMaximo < 107);
            Console.WriteLine(tesouro.Count);
        }
    }
}
