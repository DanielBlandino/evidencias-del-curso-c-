using System;

class Coche
{
    // Campo privado
    private string marca;

    // Propiedad pública
    public string Modelo { get; set; }

    // Constructor público
    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        Modelo = modelo;
    }

    // Método público
    public void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {Modelo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Coche
        Coche miCoche = new Coche("Toyota", "Corolla");
        miCoche.MostrarDetalles();
    }
}
