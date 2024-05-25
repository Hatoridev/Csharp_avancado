using System;

class Carro
{
    public string Nome;
    public string Marca;
    public double Potencia;

    public Carro(string nome, string marca, double potencia)
    {
        Nome = nome;
        Marca = marca;
        Potencia = potencia;
    }

    public Carro()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        var carro = new Carro();
        carro.Nome = "Hilux";
        carro.Marca = "Toyota";
        carro.Potencia = 3.1;
        Console.WriteLine($"{carro.Nome} {carro.Marca} {carro.Potencia}");

        var carro2 = new Carro("Celta", "Chevrolet", 1.0);
        Console.WriteLine($"{carro2.Nome} {carro2.Marca} {carro2.Potencia}");
    }
}

/*
Comentários explicativos:

1. A classe `Carro` é declarada com três campos públicos: `Nome` (do tipo `string`), `Marca` (do tipo `string`) e `Potencia` (do tipo `double`).

2. O construtor `Carro(string nome, string marca, double potencia)` inicializa os campos `Nome`, `Marca` e `Potencia` com os valores fornecidos como argumentos.
3. O construtor padrão `Carro()` é declarado para permitir a criação de instâncias da classe `Carro` sem a necessidade de fornecer argumentos.

4. A classe `Program` contém o método `Main`, que é o ponto de entrada do programa.
5. No método `Main`, uma instância da classe `Carro` é criada utilizando o construtor padrão e os campos são inicializados com os valores "Hilux", "Toyota" e 3.1, respectivamente.

6. O método `Console.WriteLine` é utilizado para imprimir os valores dos campos `Nome`, `Marca` e `Potencia` da instância `carro` no console.

7. Outra instância da classe `Carro` é criada utilizando o construtor que recebe argumentos, com os valores "Celta", "Chevrolet" e 1.0, respectivamente.

8. O método `Console.WriteLine` é utilizado para imprimir os valores dos campos `Nome`, `Marca` e `Potencia` da instância `carro2` no console.
*/

