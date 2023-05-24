using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosComRetorno
    {

        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }
            public int MultiplicarS(int a, int b)
            {
                return a * b;
            }
        }



        public static void Executar()
        {
            Console.WriteLine();

        }
    }
}