using System;

namespace DelegateExample
{
    // Definindo um delegate que aponta para métodos que recebem dois doubles e retornam um double
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        // Classe Calculadora com métodos estáticos
        class Calculadora
        {
            // Método que retorna o maior valor entre X e Y
            public static double Max(double x, double y)
            {
                if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }

            // Método que soma dois valores
            public static double Soma(double x, double y)
            {
                return x + y;
            }
        }

        // Método Main como ponto de entrada do programa
        static void Main(string[] args)
        {
            double a = 10;
            double b = 30;

            // Associando o delegate ao método Soma da classe Calculadora
            BinaryNumericOperation operacao = Calculadora.Soma;
            Console.WriteLine(operacao(a, b)); // Saída: 40
        }
    }
}

// Comentários explicativos no final do arquivo:

// O namespace DelegateExample contém todas as classes e métodos relacionados ao exemplo de uso de delegates.

// O delegate BinaryNumericOperation define um tipo que aponta para métodos que recebem dois doubles e retornam um double.

// A classe Calculadora contém dois métodos estáticos: Max, que retorna o maior valor entre dois doubles, e Soma, que retorna a soma de dois doubles.

// O método Main é o ponto de entrada do programa, onde são definidos dois valores a e b, e um delegate operacao é associado ao método Soma.

// O delegate é então utilizado para chamar o método Soma com os valores a e b, e o resultado é exibido no console.

