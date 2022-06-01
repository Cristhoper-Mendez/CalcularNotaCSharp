using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularNota
{
    public class Estudiante
    {
        private string _carnet;
        private string _nombreCompleto;
        private double _notaParcial1;
        private double _notaParcial2;
        private double _notaParcial3;
        private double _notaFinal;

        public Estudiante(
            string carnet,
            string nombreCompleto,
            double notaParcial1,
            double notaParcial2,
            double notaParcial3)
        {
            _carnet = carnet;
            _nombreCompleto = nombreCompleto;
            _notaParcial1 = notaParcial1;
            _notaParcial2 = notaParcial2;
            _notaParcial3 = notaParcial3;

        }

        public double NotaParcial1 { get => _notaParcial1; set => _notaParcial1 = value; }
        public double NotaParcial2 { get => _notaParcial2; set => _notaParcial2 = value; }
        public double NotaParcial3 { get => _notaParcial3; set => _notaParcial3 = value; }

        public void CalcularNotaFinal()
        {
            double resultado = (_notaParcial1 + _notaParcial2 + _notaParcial3) / 3;
            _notaFinal = Math.Round(resultado, 2);
        }

        public void VerDatos()
        {
            Console.WriteLine("Nombre completo: " + _nombreCompleto);
            Console.WriteLine("Carnet: " + _carnet);
            Console.WriteLine("Nota del primer parcial: " + _notaParcial1);
            Console.WriteLine("Nota del segundo parcial: " + _notaParcial2);
            Console.WriteLine("Nota del tercer parcial: " + _notaParcial3);
            Console.WriteLine("Nota final: " + _notaFinal);
            Console.WriteLine("Estado: ", ObtenerEstado());
        }

        public string ObtenerEstado()
        {
            return _notaFinal >= 6 ? "APROBADO" : "DESAPROBADO";
        }
    }
}
