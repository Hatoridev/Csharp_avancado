using System;

public class Program
{
    // Método para multiplicar dois números, com valores padrão
    public static double Multiplica(double x = 3.4, double y = 3)
    {
        return x * y;
    }

    // Método principal
    public static void Main()
    {
        // Chamando o método Multiplica sem passar argumentos
        double resultado = Multiplica();

        // Exibindo o resultado
        Console.WriteLine("Resultado da multiplicação: " + resultado);
    }
}

/*
Comentários explicativos:

1. O método `Multiplica` é declarado como público e estático, o que significa que pode ser chamado sem a necessidade de uma instância da classe.

2. O método `Multiplica` recebe dois parâmetros do tipo double, `x` e `y`, com valores padrão de 3.4 e 3, respectivamente.

3. Dentro do método, é calculado o produto de `x` e `y` usando o operador `*` e retornado o resultado.

4. No método `Main`, é chamado o método `Multiplica` sem passar argumentos, o que resulta na utilização dos valores padrão.

5. O resultado da multiplicação é armazenado na variável `resultado` e exibido no console.
*/

