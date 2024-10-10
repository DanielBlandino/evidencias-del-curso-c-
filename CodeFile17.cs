using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int numero = int.Parse("abc"); // Esto causará una excepción
            Console.WriteLine(numero);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: El formato de entrada no es válido.");
            Console.WriteLine($"Detalle del error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ha ocurrido un error inesperado.");
            Console.WriteLine($"Detalle del error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finalizando el bloque try-catch.");
        }
    }
}
