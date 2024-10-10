using System;

class Calculadora
{
    // Método estático (no requiere instancia)
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    // Método de instancia
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Llamar a un método estático
        int suma = Calculadora.Sumar(5, 3);
        Console.WriteLine($"Suma: {suma}");

        // Crear una instancia de Calculadora y llamar a un método de instancia
        Calculadora calc = new Calculadora();
        int producto = calc.Multiplicar(4, 6);
        Console.WriteLine($"Producto: {producto}");
    }
}
