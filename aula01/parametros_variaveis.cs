using System;

class Program
{
    public static void Despedida(params string[] alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine("Tchau {0}, até a próxima aula", aluno);
        }
    }

    static void Main()
    {
        Despedida("Joao", "Thiago", "Antonio");
    }
}

/*
Comentários explicativos:

1. O método estático `Despedida` recebe um número variável de strings como parâmetro, representando os nomes dos alunos.

2. O parâmetro `params` permite que você passe um número variável de argumentos para o método.

3. Dentro do método `Despedida`, há um loop `foreach` que itera sobre cada aluno na lista de alunos.

4. Dentro do loop, o método `Console.WriteLine` é chamado para imprimir uma mensagem de despedida para cada aluno.

5. O método `Main` é o ponto de entrada do programa.

6. No método `Main`, o método `Despedida` é chamado com os argumentos "Joao", "Thiago" e "Antonio".

7. Como o método `Main` não precisa de argumentos, ele é declarado sem parâmetros.
*/

