using System;

class MetodosEstaticos
{
    public static int somar(int x, int y)
    {
        return x + y;
    }

    public int multiplicar(int x, int y)
    {
        return x * y;
    }

    static void Main(string[] args)
    {
        var result = MetodosEstaticos.somar(3, 3);
        Console.WriteLine("A soma é igual a: {0}", result);

        MetodosEstaticos calc = new MetodosEstaticos();
        Console.WriteLine(calc.multiplicar(3, 4));
    }
}

/*
Comentários explicativos:

1. A classe `MetodosEstaticos` contém métodos estáticos e de instância para realizar operações de soma e multiplicação.

2. O método estático `somar` recebe dois números inteiros como parâmetros e retorna a soma deles.

3. O método de instância `multiplicar` recebe dois números inteiros como parâmetros e retorna o resultado da multiplicação deles.

4. O método `Main` é o ponto de entrada do programa.

5. No método `Main`, a função `somar` é chamada diretamente usando a classe `MetodosEstaticos`, sem a necessidade de criar uma instância.

6. O método `Console.WriteLine` é usado para imprimir o resultado da soma no console.

7. Para chamar o método de instância `multiplicar`, é necessário criar uma instância da classe `MetodosEstaticos`.

8. O método `Console.WriteLine` é usado para imprimir o resultado da multiplicação no console.
*/

