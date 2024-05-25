using System;
using System.Linq;

namespace Ling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo um array de inteiros
            int[] numeros = new int[] { 4, 5, 7, 8 };

            // Usando LINQ para filtrar os números pares
            var operacao = numeros.Where(x => x % 2 == 0);

            // Iterando sobre os números filtrados e exibindo no console
            foreach (int x in operacao)
            {
                Console.WriteLine(x);
            }
        }
    }
}

// Comentários explicativos no final do arquivo:

// O namespace Ling contém a classe Program que demonstra o uso de LINQ.

// A classe Program contém o método Main, que é o ponto de entrada do programa.
// No método Main, é definido um array de inteiros chamado numeros.

// O método Where do LINQ é utilizado para filtrar os números pares no array numeros.

// A variável operacao contém os números filtrados, e um loop foreach é utilizado para exibir cada número par no console.

