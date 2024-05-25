using System;

public enum Genero { Filme, Serie, Documentario };

public class Filme
{
    public string Nome;
    public Genero Tipovideo;
}

public class Enumt
{
    static void Main()
    {
        // Converte o enum Genero para inteiro
        int cod = (int)Genero.Serie;
        Console.WriteLine(cod);
    }
}

/*
Comentários explicativos:

1. O enum `Genero` define os diferentes tipos de vídeos: Filme, Série e Documentário.

2. A classe `Filme` possui propriedades para o nome do filme e o tipo de vídeo (Genero).

3. O método `Main` é o ponto de entrada do programa.

4. No método `Main`, é demonstrado como converter o valor do enum `Genero` para inteiro.
*/

