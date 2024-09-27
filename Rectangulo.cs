using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho) : base("Rectángulo")
        {
            Largo = largo;
            Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        ~Rectangulo()
        {
            Console.WriteLine("$Eliminador llamado para {Nombre}");
        }
    }
}