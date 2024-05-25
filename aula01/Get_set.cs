using System;

public class Carro
{
    private string Marca;
    private string Nome;
    private double Potencia;

    public Carro(string marca, string nome, double potencia)
    {
        Marca = marca;
        Nome = nome;
        Potencia = potencia;
    }

    public Carro()
    {
    }

    public string GetMarca()
    {
        return Marca;
    }

    public void SetMarca(string marca)
    {
        Marca = marca;
    }

    public string GetNome()
    {
        return Nome;
    }

    public static void Main(string[] args)
    {
        Carro carro = new Carro("Toyota", "Corolla", 1.8);
        Console.WriteLine("Marca: " + carro.GetMarca());
        Console.WriteLine("Nome: " + carro.GetNome());
    }
}

/*
Comentários explicativos:

1. A classe `Carro` define um modelo básico de carro com propriedades para marca, nome e potência.

2. As propriedades `Marca`, `Nome` e `Potencia` são privadas para encapsulamento.

3. Um construtor personalizado `Carro(string marca, string nome, double potencia)` é definido para inicializar as propriedades.

4. Um construtor padrão `Carro()` também é definido para permitir a criação de instâncias sem argumentos.

5. Métodos públicos `GetMarca` e `SetMarca` são definidos para acessar e modificar a propriedade `Marca`.

6. Um método público `GetNome` é definido para acessar a propriedade `Nome`.

7. O método estático `Main` é o ponto de entrada do programa.

8. O método `Main` pode ser usado para testar a classe `Carro`.
*/

