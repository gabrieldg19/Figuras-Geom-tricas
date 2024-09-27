using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    public abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }

        public FiguraGeometrica(string nombre)
        {
            Nombre = nombre;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        ~FiguraGeometrica()
        {
            Console.WriteLine($"{Nombre} eliminada.");
        }
    }
}