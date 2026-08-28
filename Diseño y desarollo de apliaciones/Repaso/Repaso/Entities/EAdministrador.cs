using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entities
{
    public class EAdministrador : Empleado
    {
        public float monto { get; set; }
        public override void CalcularSueldo()
        {
            sueldo = monto;
        }
    }
}
