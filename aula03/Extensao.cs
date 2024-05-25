using System;

namespace Extensao
{
    // Definindo uma classe estática para métodos de extensão
    public static class CalculadoraExtensao
    {
        // Método de extensão para somar dois números do tipo double
        public static double Soma(this double n1, double n2)
        {
            return n1 + n2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;

            // Usando o método de extensão Soma para somar x com 7
            Console.WriteLine(x.Soma(7)); // Saída: 10

            // Usando o método de extensão Soma diretamente em um literal double
            Console.WriteLine(9.2.Soma(7)); // Saída: 16.2
        }
    }
}

// Comentários explicativos no final do arquivo:

// O namespace Extensao contém a classe CalculadoraExtensao e a classe Program.

// A classe CalculadoraExtensao é estática e contém métodos de extensão para o tipo double.

// O método de extensão Soma permite somar dois valores do tipo double, onde o primeiro valor é o receptor do método.

// A classe Program contém o método Main, que é o ponto de entrada do programa.

// No método Main, o método de extensão Soma é utilizado para somar os valores e exibir os resultados no console.

