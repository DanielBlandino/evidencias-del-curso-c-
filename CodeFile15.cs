using System;

enum DiaSemana { Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo }

class Program
{
    static void Main(string[] args)
    {
        DiaSemana dia = DiaSemana.Miércoles;

        switch (dia)
        {
            case DiaSemana.Lunes:
                Console.WriteLine("Es lunes, inicio de semana.");
                break;
            case DiaSemana.Miércoles:
                Console.WriteLine("Es miércoles, mitad de semana.");
                break;
            case DiaSemana.Viernes:
                Console.WriteLine("Es viernes, casi fin de semana.");
                break;
            default:
                Console.WriteLine("Es un día normal.");
                break;
        }
    }
}
