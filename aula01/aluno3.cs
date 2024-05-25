using System;

class Aluno
{
    public string Nome; 
    public int Idade; 
    public int Serie;

    public string Retorno()
    {
        return string.Format($"O aluno {Nome} tem {Idade} anos e pertence ao {Serie}º ano");
    }

    public void RetornoConsole()
    {
        Console.WriteLine(Retorno());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "João";
        aluno1.Idade = 13;
        aluno1.Serie = 6;
        aluno1.RetornoConsole();
    }
}

/*
Comentários explicativos:

1. A classe `Aluno` é declarada com três campos públicos: `Nome` (do tipo `string`), `Idade` (do tipo `int`) e `Serie` (do tipo `int`).

2. O método `Retorno` da classe `Aluno` retorna uma string formatada com os valores dos campos `Nome`, `Idade` e `Serie`.

3. O método `string.Format` é utilizado para construir a string formatada, inserindo os valores das propriedades `Nome`, `Idade` e `Serie` na string de saída.

4. O método `RetornoConsole` da classe `Aluno` chama o método `Retorno` e imprime o resultado no console usando `Console.WriteLine`.

5. A classe `Program` contém o método `Main`, que é o ponto de entrada do programa.

6. No método `Main`, uma instância da classe `Aluno` é criada e inicializada com os valores "João", 13 e 6 para os campos `Nome`, `Idade` e `Serie`, respectivamente.

7. O método `RetornoConsole` da instância `aluno1` é chamado para imprimir as informações do aluno no console.
*/

