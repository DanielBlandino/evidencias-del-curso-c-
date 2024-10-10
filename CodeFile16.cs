using System;

class Program
{
    // Declarar un evento
    public static event Action OnSaludo;

    static void Main(string[] args)
    {
        // Suscribirse al evento
        OnSaludo += MostrarMensaje;

        // Disparar el evento
        if (OnSaludo != null)
        {
            OnSaludo();
        }
    }

    // Método que se ejecuta cuando el evento se dispara
    static void MostrarMensaje()
    {
        Console.WriteLine("¡Hola! Este es un evento disparado.");
    }
}
