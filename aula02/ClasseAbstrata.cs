using System;

public abstract class Telefone
{
    public abstract string Tipo();
}

public class Xiaomi : Telefone
{
    public override string Tipo()
    {
        return "Note 8 Pro";
    }
}

public class Program
{
    public static void Main()
    {
        Telefone meuTelefone = new Xiaomi();
        Console.WriteLine("Tipo do telefone: " + meuTelefone.Tipo());
    }
}

// Comentários explicativos no final do arquivo:

// A classe abstrata Telefone define um método abstrato Tipo que deve ser implementado por qualquer classe derivada.
//
// A classe Xiaomi herda de Telefone e implementa o método Tipo, retornando uma string "Note 8 Pro".
//
// A classe Program contém o método Main, que é o ponto de entrada do programa.
//
// No método Main, criamos uma instância da classe Xiaomi e chamamos o método Tipo para exibir o tipo do telefone no console.

