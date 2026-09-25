using System;

namespace Hito2_HerenciaPolimorfismo
{
    public class Circulo : FiguraGeometrica, IDibujable
    {
        public double Radio { get; }

        public Circulo(string nombre, double radio) : base(nombre)
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El radio debe ser mayor a cero.");
            }
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public string Dibujar()
        {
            return "   ***   \n" +
                   " ******* \n" +
                   "*********\n" +
                   " ******* \n" +
                   "   ***   ";
        }
    }
}
