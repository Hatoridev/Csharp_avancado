using System;

public class Program
{
    // Método para alterar o valor de um número usando ref
    public static void AlterarRef(int numero)
    {
        numero += 500;
        // A alteração dentro do método não afeta o valor original devido à passagem por valor
    }

    // Método para alterar o valor de um número usando out
    public static void AlterarOut(int numero)
    {
        numero += 50;
        // A alteração dentro do método não afeta o valor original devido à passagem por valor
    }

    public static void Main()
    {
        int x = 5;

        // Chamando o método AlterarRef com o argumento x
        AlterarRef(x);

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

1. O método `AlterarRef` recebe um parâmetro `numero` por valor e adiciona 500 ao seu valor, porém, como a passagem é por valor, a alteração feita dentro do método não afeta o valor original.

2. O método `AlterarOut` recebe um parâmetro `numero` por valor e adiciona 50 ao seu valor, mas assim como o anterior, a alteração dentro do método não afeta o valor original devido à passagem por valor.

3. O método `Main` é o ponto de entrada do programa.

4. No método `Main`, são declaradas duas variáveis, x e y.

5. O método `AlterarRef` é chamado com o argumento x, mas o valor de x não é afetado pela alteração dentro do método.

6. O valor de x é impresso após chamar o método `AlterarRef`.

7. O método `AlterarOut` é chamado com o argumento y, mas o valor de y não é afetado pela alteração dentro do método.
8. O valor de y é impresso após chamar o método `AlterarOut`.
*/

