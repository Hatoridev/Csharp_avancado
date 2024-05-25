using System;

// Definição da struct Pontos
public struct Pontos
{
    public int x; // Coordenada X
    public int Y; // Coordenada Y
}

// Definição da classe Pontoc
public class Pontoc
{
    public int X; // Coordenada X
    public int Y; // Coordenada Y
}

// Classe principal StructClasse com o método Main
public class StructClasse
{
    public static void Main()
    {
        // Criando uma instância da struct Pontos
        Pontos ponto = new Pontos { x = 5, Y = 3 };

        // Copiando ponto através do valor
        Pontos ponto2 = ponto;

        // Modificando o valor de ponto.X
        ponto.x = 3;

        // Imprimindo o valor de ponto.X e ponto2.X
        Console.WriteLine("Ponto: {0}", ponto.x);
        Console.WriteLine("Ponto 2: {0}", ponto2.x);

        // Criando uma instância da classe Pontoc
        Pontoc ponto3 = new Pontoc { X = 6, Y = 9 };

        // Copiando ponto3 para ponto4
        Pontoc ponto4 = ponto3;

        // Modificando o valor de ponto3.X
        ponto3.X = 3;

        // Imprimindo o valor de ponto3.X e ponto4.X
        Console.WriteLine("Ponto 3 = {0}, Ponto 4 = {1}", ponto3.X, ponto4.X);
    }
}

/*
Comentários explicativos:

1. A struct `Pontos` define uma estrutura para representar pontos no plano cartesiano, com as coordenadas X e Y.

2. A classe `Pontoc` define uma classe similar à struct `Pontos`, mas com membros públicos ao invés de campos públicos.

3. O método `Main` é o ponto de entrada do programa.

4. No método `Main`, são demonstradas as diferenças entre structs e classes ao copiar por valor e por referência.

5. Primeiro, são criadas instâncias da struct `Pontos` e da classe `Pontoc`.

6. Em seguida, são feitas cópias das instâncias e modificados os valores das cópias e das instâncias originais.

7. A saída no console mostra como as mudanças afetam cada instância.
*/

