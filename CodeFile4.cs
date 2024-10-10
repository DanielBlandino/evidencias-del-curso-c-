using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5 };

        // Acceder e imprimir elementos del arreglo
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Elemento en la posición {i}: {numeros[i]}");
        }
    }
}
