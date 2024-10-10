using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string rutaArchivo = "datos.txt";
        string contenido = "Este es un archivo de prueba.";

        // Escribir en un archivo
        File.WriteAllText(rutaArchivo, contenido);
        Console.WriteLine("Archivo escrito con éxito.");

        // Leer del archivo
        if (File.Exists(rutaArchivo))
        {
            string leerContenido = File.ReadAllText(rutaArchivo);
            Console.WriteLine($"Contenido del archivo: {leerContenido}");
        }
    }
}
