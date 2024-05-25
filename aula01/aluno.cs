using System;

class Aluno
{
    public string Nome;
    public int Idade;
    public int Serie;
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno(); 
        aluno1.Nome = "João"; 
        aluno1.Idade = 13; 
        aluno1.Serie = 6;

        Console.WriteLine($"O aluno {aluno1.Nome} tem {aluno1.Idade} anos e pertence ao {aluno1.Serie}º ano");
    }
}

/*
Comentários explicativos:

1. A classe `Aluno` é declarada para conter três campos públicos: `Nome` (do tipo `string`), `Idade` (do tipo `int`) e `Serie` (do tipo `int`).

2. A classe `Program` é declarada para conter o método `Main`.

3. O método `Main` é o ponto de entrada do programa, onde a execução começa.

4. Dentro do método `Main`, uma instância da classe `Aluno` é criada e atribuída à variável `aluno1`.

5. Os campos `Nome`, `Idade` e `Serie` da instância `aluno1` são inicializados com os valores "João", 13 e 6, respectivamente.

6. O método `Console.WriteLine` é usado para imprimir uma mensagem formatada que inclui os valores dos campos `Nome`, `Idade` e `Serie` da instância `aluno1`.

7. A interpolação de strings ($"...") é utilizada para incluir os valores das variáveis dentro da string de saída.
*/

