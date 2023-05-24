using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {
        class RealToDolar
        {
            public double Converter()
            {
                Console.WriteLine("Informe o valor: ");
                double.TryParse(Console.ReadLine(), out double real);
                return real * 4.95;
            }
        }

        class CelsiusToFahrenheit
        {
            public double Converter()
            {
                Console.WriteLine("Informe o valor: ");
                double.TryParse(Console.ReadLine(), out double celsius);
                return celsius * 9 / 5 + 32;
            }
        }

        public static void Executar()
        {
            var realtodolar = new RealToDolar();
            var convert = realtodolar.Converter();
            Console.WriteLine(convert.ToString("F1"));
            
            var celsiusToFahrenheit = new CelsiusToFahrenheit();
            var converter = celsiusToFahrenheit.Converter();
            Console.WriteLine(convert);


        }

    }
}