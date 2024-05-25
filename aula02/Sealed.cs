using System;

// Definindo uma classe selada chamada Escola
sealed class Escola
{
}

// Classe de execução contendo o método Main
class Program
{
    public static void Main()
    {
        Escola escola = new Escola();
        Console.WriteLine("Instância da classe Escola criada com sucesso.");
    }
}

// Comentários explicativos no final do arquivo:

// A classe Escola é uma classe selada, o que significa que não pode ser herdada por outras classes.

// Classes seladas são úteis quando se deseja evitar que a classe seja estendida, garantindo que sua implementação permaneça inalterada.

// A classe Program contém o método Main, que é o ponto de entrada do programa.

// No método Main, criamos uma instância da classe Escola e exibimos uma mensagem para confirmar sua criação.

