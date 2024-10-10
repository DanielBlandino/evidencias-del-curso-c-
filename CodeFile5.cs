using System;

class Program
{
    static void Main(string[] args)
    {
        int resultado = Sumar(5, 7);
        Console.WriteLine($"La suma es: {resultado}");
    }

    // Método que suma dos números
    static int Sumar(int a, int b)
    {
        return a + b;
    }
}
