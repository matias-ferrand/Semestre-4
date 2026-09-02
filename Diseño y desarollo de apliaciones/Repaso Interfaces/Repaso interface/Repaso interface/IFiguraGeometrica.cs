using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_interface
{
    public interface IFiguraGeometrica
    {
        public float CalcularArea(float altura, float Base);
        public float CalcularPerimetro(float altura, float Base);
    }
    
}
