using System;

class Program
{
    static void Main(string[] args)
    {
        float resultado = Multiplicar(3.0f, 4.0f);
        Console.WriteLine("O resultado da multiplicação é: " + resultado);
    }

    static float Multiplicar(float x, float y)
    {
        return x * y;
    }
}

/*
Comentários explicativos:

1. A classe `Program` é declarada para conter o método `Main` e o método `Multiplicar`.

2. O método `Main` é o ponto de entrada do programa, onde a execução começa.

3. Dentro do método `Main`, o método `Multiplicar` é chamado com os argumentos `3.0f` e `4.0f`.

4. O resultado da multiplicação é armazenado na variável `resultado`.

5. O método `Console.WriteLine` é usado para imprimir o resultado no console.

6. O método `Multiplicar` é do tipo `static` para permitir sua chamada sem a necessidade de uma instância da classe `Program`.

7. O método `Multiplicar` recebe dois parâmetros do tipo float: `x` e `y`.

8. O corpo do método `Multiplicar` é definido dentro das chaves `{}`.

9. O método retorna o resultado da multiplicação de `x` e `y` usando o operador `*`.

10. O tipo de retorno do método `Multiplicar` é `float`, indicando que o valor retornado será do tipo float.
*/

