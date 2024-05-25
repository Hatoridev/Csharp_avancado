using System;

public class Mensagem
{
    private string Texto;

    // Método para exibir o texto armazenado
    public void Exibir()
    {
        Console.WriteLine(this.Texto);
    }

    // Método para obter o texto armazenado
    public string getTexto()
    {
        return this.Texto;
    }

    // Método para definir o texto
    public void setTexto(string txt)
    {
        this.Texto = txt;
    }

    // Método Main como ponto de entrada do programa
    public static void Main(string[] args)
    {
        Mensagem txt1, txt2;

        txt1 = new Mensagem();
        txt1.setTexto("CURSO AVANÇADO DE C#");
        txt1.Exibir();
    }
}

// Comentários explicativos no final do arquivo:

// A classe Mensagem armazena um texto e fornece métodos para definir, obter e exibir esse texto.
//
// O método Exibir mostra o texto armazenado no console.
//
// O método getTexto retorna o texto armazenado.
//
// O método setTexto define o texto armazenado com o valor passado como parâmetro.
//
// O método Main é o ponto de entrada do programa e demonstra a criação de objetos da classe Mensagem, definindo e exibindo um texto.

