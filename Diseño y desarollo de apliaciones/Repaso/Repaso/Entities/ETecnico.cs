using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entities
{
    public class ETecnico : Empleado
    {
        public Grado grado { get; set; }
        public float sueldoBase { get; set; }
        public override void CalcularSueldo()
        {
            switch (grado)
            {
                case Grado.junior:
                    sueldo = sueldoBase * 1.15f; 
                    break;
                case Grado.semiSenior:
                    sueldo = sueldoBase * 2.0f; 
                    break;
                case Grado.senior:
                    sueldo = sueldoBase * 3.0f;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(grado), "Grado no válido");
            }
        }
    }
}
