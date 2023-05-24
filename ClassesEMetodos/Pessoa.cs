using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        /*O metodo Format retorna uma string formatada e imprima no console*/
        {
            return string.Format($"Olá! me chamo {Nome} e tenho {Idade} anos");

        }
        public void ApresentarNoConsole()
        /*vou chamar no console o metodo que criei, Apresentar()*/
        {
            Console.WriteLine(Apresentar());
        }


    }

}