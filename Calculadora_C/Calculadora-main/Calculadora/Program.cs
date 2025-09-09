using System;
using System.Collections;
using System.Collections.Generic;
// dotnet run 
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implementando o calculo de divisao

            Stack<long> pilhaResultados = new Stack<long>(); // pilha para guardar resultados

            Calculadora calculadora = new Calculadora();

            //    Corrigindo o primeiro item rodando infinitamente 
            // while (filaOperacoes.Count >= 0) //
            while (filaOperacoes.Count > 0)
            {
                // Operacoes operacao = filaOperacoes.Peek(); //peek pega o primeiro item da fila e não permite sair      
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("\nOperação: {0}", operacao.operador);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Guardando o resultado na pilha
                pilhaResultados.Push(operacao.resultado);
                // Imprimindo fila de operações após calculo 
                ImprimirFila(filaOperacoes);

            }

             // Imprimindo a pilha de resultados ao final
            Console.WriteLine("\nResultados: ");
            foreach (var resultado in pilhaResultados)
            {
                Console.WriteLine(resultado);
            }


            // função para imprimir fila de operações a seguir
            static void ImprimirFila(Queue<Operacoes> fila)
            {   //Enquanto tiver itens na fila, ele vai constinuar rodando
                if (fila.Count > 0)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Próximas operações:");

                    // parecido com o for do python, percorre todos os itens da fila 
                    foreach (var operacao in fila)
                    {
                        // op = apelido para operacao 
                        Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
                    }

                    Console.WriteLine("---------------------");

                }
                else
                {
                    //Se a fila acabar, vai mostrar essa mensagem
                    Console.WriteLine("---------------------\n");
                    Console.WriteLine("\nNão há mais operações a seguir.");
                }

            }
        }
    }
}
