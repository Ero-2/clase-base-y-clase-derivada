using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_base_y_clase_derivada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            figura figura1 = new figura();
            rectangulo rectangulo1 = new rectangulo();

            figura1.Ancho = 5;
            figura1.Altura = 10;
            double areaFigura1 = figura1.CalcularArea();
            Console.WriteLine(figura1.CalcularArea());

            rectangulo1.Ancho = 5;
            rectangulo1.Altura = 10;
            double areaRectangulo1 = rectangulo1.CalcularArea();
            Console.WriteLine(rectangulo1.CalcularArea());

            Console.ReadKey();
        }
    }
}
