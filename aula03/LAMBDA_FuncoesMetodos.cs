using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo uma Action que exibe uma mensagem no console
        Action apresentaConsole = () =>
        {
            Console.WriteLine("Funções e Métodos");
        };

        // Chamando a Action para exibir a mensagem
        apresentaConsole();

        // Definindo uma Func que retorna um número aleatório entre 1 e 100
        Func<int> sorteio = () =>
        {
            Random random = new Random();
            return random.Next(1, 101);
        };

        // Chamando a Func e exibindo o número aleatório gerado
        Console.WriteLine(sorteio());
    }
}

// Comentários explicativos no final do arquivo:

// A classe Program contém o método Main, que é o ponto de entrada do programa.

// Dentro do método Main, uma Action chamada apresentaConsole é definida para exibir a mensagem "Funções e Métodos" no console.
// A Action é chamada para executar e exibir a mensagem no console.

// Uma Func chamada sorteio é definida para retornar um número aleatório entre 1 e 100.
// A Func é chamada para gerar e exibir o número aleatório no console.

