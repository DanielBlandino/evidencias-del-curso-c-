using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, me llamo {Nombre} y tengo {Edad} años.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Persona
        Persona persona = new Persona();
        persona.Nombre = "Daniel";
        persona.Edad = 25;
        persona.Presentarse();
    }
}
