using System;

class Program
{
    static void Main(string[] args)
    {
        string saludo = "Hola, Mundo!";
        string nombre = "Daniel";

        // Concatenar cadenas
        string mensaje = saludo + " Mi nombre es " + nombre;
        Console.WriteLine(mensaje);

        // Interpolación de cadenas
        string mensajeInterpolado = $"Bienvenido, {nombre}. Hoy es {DateTime.Now.ToShortDateString()}";
        Console.WriteLine(mensajeInterpolado);

        // Métodos de cadenas
        Console.WriteLine($"Longitud de la cadena: {saludo.Length}");
        Console.WriteLine($"En mayúsculas: {saludo.ToUpper()}");
        Console.WriteLine($"En minúsculas: {saludo.ToLower()}");
    }
}
