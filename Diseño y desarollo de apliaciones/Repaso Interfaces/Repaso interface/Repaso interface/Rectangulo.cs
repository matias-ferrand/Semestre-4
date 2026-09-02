using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso_interface;

namespace Repaso_interface
{
    public class Rectangulo: IFiguraGeometrica
    {
        public float altura { get; set; }
        public float Base { get; set; }
        public float CalcularArea(float altura, float Base)
        {
            return Base * altura;
        }
        public float CalcularPerimetro(float altura, float Base)
        {
            return 2 * (Base + altura);
        }
    }
}
