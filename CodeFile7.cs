using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtener la fecha y hora actual
        DateTime fechaActual = DateTime.Now;
        Console.WriteLine($"Fecha y hora actual: {fechaActual}");

        // Crear una fecha específica
        DateTime fechaEspecifica = new DateTime(2023, 10, 9);
        Console.WriteLine($"Fecha específica: {fechaEspecifica.ToShortDateString()}");

        // Sumar días a la fecha actual
        DateTime fechaFutura = fechaActual.AddDays(5);
        Console.WriteLine($"Fecha en 5 días: {fechaFutura.ToShortDateString()}");
    }
}
