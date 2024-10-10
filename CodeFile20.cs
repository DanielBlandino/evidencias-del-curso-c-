using System;
using System.Collections.Generic; // Namespace para colecciones
using System.IO; // Namespace para manejo de archivos

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usar una clase de System.IO para trabajar con archivos
            string rutaArchivo = "archivo.txt";
            File.WriteAllText(rutaArchivo, "Texto de ejemplo.");

            // Usar una colección de System.Collections.Generic
            List<string> listaNombres = new List<string> { "Daniel", "Carlos", "Ana" };
            foreach (var nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
