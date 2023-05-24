using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados  - Fundamentos", LendoDados.Executar },
                {"Formatando Numeros  - Fundamentos", FormatandoNumeros.Executar },
                {"Operadores Aritmetricos  - Fundamentos", OperadoresAritmeticos.Executar },
                {"Exercício 1 - Fundamentos", Exercicios.Executar },
                {"Exercício IF e ELSE - Fundamentos", ExercicoIfElse.Executar },

                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Exercicio Switch - Estruturas de Controle", ExercicioSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle", EstruturaWhileEFor.Executar},
                {"Exercicio While e For - Estruturas de Controle", ExercicioRepeticao.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},

                {"Classes e Metodos - Classes e Metodos", Membros.Executar},
                {"Construtor - Classes e Metodos", MetodosComRetorno.Executar},
                {"Exercicio Metodos e Classes", ExerciciosMetodosComRetorno.Executar}


            }); ;

            central.SelecionarEExecutar();
        }
    }
}