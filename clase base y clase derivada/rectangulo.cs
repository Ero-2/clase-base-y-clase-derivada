using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_base_y_clase_derivada
{
    public class rectangulo: figura
    {
        public override double CalcularArea()
        {
            return Ancho * Altura;
        }

     

    }
}
