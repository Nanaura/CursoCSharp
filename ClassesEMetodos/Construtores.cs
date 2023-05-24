using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Cliente
    {
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereço;
        public int Idade;

        public Cliente(string nome, string cpf, string sexo, string endereco, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Endereço = endereco;
            Sexo = sexo;
            Idade = idade;
        }

        /*criando construtor comum*/
        public Cliente()
        {


        }

        class Construtor
        {


            public static void Executar()
            {
                var cliente1 = new Cliente();//new cliente() é um construtor, ele é padrão e não recebe parametro.
                cliente1.Nome = "Luiz Iñácio";
                cliente1.Cpf = "50564978962";
                cliente1.Sexo = "M";
                cliente1.Endereço = "Vila Pires";
                cliente1.Idade = 66;

                var cliente2 = new Cliente("Rogério", "5028399870", "M", "Ramiro Corleoni", 40);
                var cliente3 = new Cliente()
                {
                    Nome = "Amanda",
                    Sexo = "F",
                    Endereço = "Av Portugal",
                    Idade = 25

                };
                Console.WriteLine($"Olá {cliente1.Nome} você tem {cliente1.Idade} anos  ");
            }
        }
    }
}
