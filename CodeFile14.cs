using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Filtrar números pares usando LINQ
        var numerosPares = numeros.Where(n => n % 2 == 0);

        // Mostrar los números pares
        Console.WriteLine("Números pares:");
        foreach (var numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
}
