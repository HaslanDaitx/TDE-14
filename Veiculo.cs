using System.Runtime.CompilerServices;

public abstract class Veiculo
{
    public string Marca { get; set; }

    public String Modelo { get; set; }

    public Veiculo (string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;

    }

    public abstract void Ligar();

    public void Desligar()
    {
        Console.WriteLine("O veiculo está desligado");
    }
    

}