using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Leer un archivo de texto usando System.IO
        string ruta = "archivo.txt";
        if (File.Exists(ruta))
        {
            string contenido = File.ReadAllText(ruta);
            Console.WriteLine($"Contenido del archivo: {contenido}");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
