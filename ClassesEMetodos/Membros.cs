using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            /**instanciando a classe Pessoa e criando um objeto pessoa1**/

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Cleiton Peres";
            pessoa1.Idade = 45;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Cleber";
            pessoa2.Idade = 18;

            pessoa1.ApresentarNoConsole();


            Animal animal1 = new Animal();
            animal1.Nome = "Julie";
            animal1.Raça = "Yourk Shire";
            animal1.Peso = 1.220;

            Animal animal2 = new Animal();
            animal2.Nome = "Shakira";
            animal2.Raça = "Shitzu";
            animal2.Peso = 3.00;
        }
    }
}