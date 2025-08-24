using System.ComponentModel;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

Automoviles num = new Automoviles() {num_llantas = 4, placa = "dtebjf"};
Automoviles newnum = new Motos() { num_llantas = 2, placa = "hdhdd", nombre = "albert" };
Console.WriteLine(newnum.num_llantas);

public class Automoviles
{
    public int num_llantas;
    public string? placa;
    public List<int> motos = new List<int>();
}

public class Motos : Automoviles
{
    public string? nombre;
}