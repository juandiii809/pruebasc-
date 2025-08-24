using System.ComponentModel;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

Automoviles num = new Automoviles() {num_llantas = 4, placa = "dtebjf"};
Automoviles newnum = new Motos() { num_llantas = 2, placa = "hdhdd", nombre = "albert" };
Console.WriteLine(newnum.placa);

List<Automoviles> lista = [newnum];

foreach (var i in lista)
{
    Console.WriteLine(lista);
}


public class Automoviles
{
    public int num_llantas;
    public string? placa;
}

public class Motos : Automoviles
{
    public string? nombre;
}