using System;

namespace CalcularNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("KA1223D", "Ervin Xavier", 8.3, 6.5, 7.5);

            estudiante.CalcularNotaFinal();
            estudiante.VerDatos();
        }
    }
}
