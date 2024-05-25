using System;

public class Professor
{
    protected readonly float salariomaximo;
    protected float salarioatual;

    // Construtor que define o salário máximo para o professor
    public Professor(float salarioMaximo)
    {
        this.salariomaximo = salarioMaximo;
        this.salarioatual = 0;
    }

    // Método protegido para modificar o salário do professor
    protected float ModificarSalario(float Modf)
    {
        float novoSalario = salarioatual + Modf;

        if (novoSalario < 0)
        {
            salarioatual = 0;
        }
        else if (novoSalario > salariomaximo)
        {
            salarioatual = salariomaximo;
        }
        else
        {
            salarioatual = novoSalario;
        }

        return salarioatual;
    }

    // Método público para aumentar o salário do professor em 500
    public float AumentaSalario()
    {
        return ModificarSalario(+500);
    }

    // Método público para diminuir o salário do professor em 500
    public float DiminuiSalario()
    {
        return ModificarSalario(-500);
    }
}

public class Prof : Professor
{
    // Construtor que inicializa a classe base com um salário máximo de 1400
    public Prof() : base(1400) {}

    // Método Main como ponto de entrada do programa
    public static void Main()
    {
        Console.WriteLine("Professor 1: ");
        Prof prof1 = new Prof();
        Console.WriteLine(prof1.AumentaSalario()); // Salário: 500
        Console.WriteLine(prof1.AumentaSalario()); // Salário: 1000
        Console.WriteLine(prof1.AumentaSalario()); // Salário: 1400 (atinge o máximo)
        Console.WriteLine(prof1.AumentaSalario()); // Salário: 1400 (não aumenta mais)
    }
}

// Comentários explicativos no final do arquivo:

// A classe Professor representa um professor com um salário máximo definido.
//
// Ela contém métodos para modificar o salário do professor, aumentando ou diminuindo em uma quantia fixa.
//
// O método ModificarSalario é protegido para encapsular a lógica de modificação do salário, garantindo que não ultrapasse o salário máximo nem seja negativo.
//
// Os métodos AumentaSalario e DiminuiSalario são públicos para permitir a manipulação do salário do professor.

// A classe Prof é derivada da classe Professor e inicializa a classe base com um salário máximo de 1400.
//
// O método Main na classe Prof demonstra a criação de um objeto Prof e a utilização dos métodos AumentaSalario.

