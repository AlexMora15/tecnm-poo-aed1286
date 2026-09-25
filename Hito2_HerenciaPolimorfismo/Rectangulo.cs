using System;

namespace Hito2_HerenciaPolimorfismo
{
    public class Rectangulo : FiguraGeometrica, IDibujable
    {
        public double Base { get; }
        public double Altura { get; }

        public Rectangulo(string nombre, double ancho, double alto) : base(nombre)
        {
            if (ancho <= 0 || alto <= 0)
            {
                throw new ArgumentException("Las dimensiones deben ser mayores a cero.");
            }
            Base = ancho;
            Altura = alto;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return (Base * 2) + (Altura * 2);
        }

        public string Dibujar()
        {
            return "-------------------\n" +
                   "|                 |\n" +
                   "|                 |\n" +
                   "-------------------";
        }
    }
}
