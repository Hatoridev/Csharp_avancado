using System;

class MetodosEstaticos
{
    public static int somar(int x, int y)
    {
        return x + y;
    }

    public static int multiplicar(int x, int y)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        var result = MetodosEstaticos.somar(3, 3);
        Console.WriteLine("A soma é igual a: {0}", result);

        Console.WriteLine(MetodosEstaticos.multiplicar(3, 4));
    }
}

/*
Comentários explicativos:

1. A classe `MetodosEstaticos` contém métodos estáticos para realizar operações de soma e multiplicação.

2. O método `somar` recebe dois números inteiros como parâmetros e retorna a soma deles.

3. O método `multiplicar` recebe dois números inteiros como parâmetros e retorna o resultado da multiplicação deles.

4. O método `Main` é o ponto de entrada do programa.

5. No método `Main`, a função `somar` é chamada com os argumentos 3 e 3, e o resultado é armazenado na variável `result`.

6. O método `Console.WriteLine` é usado para imprimir o resultado da soma no console.

7. A função `multiplicar` é chamada com os argumentos 3 e 4, e o resultado é diretamente impresso no console usando `Console.WriteLine`.
*/

