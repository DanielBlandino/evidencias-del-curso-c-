using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de enteros
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        // Agregar y eliminar elementos
        numeros.Add(6);
        numeros.Remove(2);

        // Recorrer la lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
