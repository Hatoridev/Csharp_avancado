using System;

public class Program
{
    // Método para alterar o valor de um número usando ref
    public static void AlterarRef(ref int numero)
    {
        numero += 500;
        // A alteração dentro do método afeta o valor original devido à passagem por referência
    }

    // Método para alterar o valor de um número
    public static void AlterarOut(int numero)
    {
        numero = 0;
        // A alteração do parâmetro não afeta o valor original fora do método
        numero += 50;
    }

    public static void Main()
    {
        int x = 5;

        // Chamando o método AlterarRef com o argumento x por referência
        AlterarRef(ref x);

        // Imprimindo o valor de x após chamar AlterarRef
        Console.WriteLine("Valor de x após AlterarRef: " + x);

        int y = 8;

        // Chamando o método AlterarOut com o argumento y
        AlterarOut(y);

        // Imprimindo o valor de y após chamar AlterarOut
        Console.WriteLine("Valor de y após AlterarOut: " + y);
    }
}

/*
Comentários explicativos:

1. O método `AlterarRef` recebe um parâmetro `numero` por referência (`ref`) e adiciona 500 ao seu valor, afetando diretamente o valor original.

2. O método `AlterarOut` recebe um parâmetro `numero` por valor e tenta alterar seu valor, mas como a passagem é por valor, a alteração feita dentro do método não afeta o valor original.

3. O método `Main` é o ponto de entrada do programa.

4. No método `Main`, são declaradas duas variáveis, x e y.

5. O método `AlterarRef` é chamado com o argumento x por referência, resultando na alteração direta do valor de x.

6. O valor de x é impresso após chamar o método `AlterarRef`.

7. O método `AlterarOut` é chamado com o argumento y, mas como a passagem é por valor, a alteração dentro do método não afeta o valor original de y.


8. O valor de y é impresso após chamar o método `AlterarOut`.
*/

