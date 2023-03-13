using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_base_y_clase_derivada
{
    public class figura
    {
        public double Ancho
        {
            get; set;
        }

        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Ancho * Altura;
        }
        


    }    

}        

   
   

