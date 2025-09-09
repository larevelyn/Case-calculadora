using System;
namespace Calculadora
{
    public class Operacoes
    {
        // Foi necessário mudar o tipo de dado de int para long, 
        // pois a variavel não estava suportando o valor recebido (estouro ou overflow)
        public long valorA { get; set; }
        public char operador { get; set; }
        public long valorB { get; set; }
        public long resultado { get; set; }

    }
}
