using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        // Operadores aritméticos
        int suma = a + b;
        int resta = a - b;
        int producto = a * b;
        int division = a / b;
        int modulo = a % b;

        Console.WriteLine($"Suma: {suma}, Resta: {resta}, Producto: {producto}, División: {division}, Módulo: {modulo}");

        // Operador relacional
        bool esMayor = a > b;
        Console.WriteLine($"¿a es mayor que b? {esMayor}");

        // Operador lógico
        bool resultado = (a > 5) && (b < 10);
        Console.WriteLine($"Resultado lógico: {resultado}");
    }
}
