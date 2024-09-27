using System;
namespace Figuras_Geométricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(7);
            Rectangulo rectangulo = new Rectangulo(4,8);
            Triangulo triangulo = new Triangulo(4,2,5,6,9);

            Console.WriteLine($"Círculo - Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Círculo - Perímetro: {circulo.CalcularPerimetro()}");

            Console.WriteLine($"Rectángulo - Área: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Rectángulo - Perímetro: {rectangulo.CalcularPerimetro()}");

            Console.WriteLine($"Triángulo - Área: {triangulo.CalcularArea()}");
            Console.WriteLine($"Triángulo - Perímetro: {triangulo.CalcularPerimetro()}");
        }
    }
}
