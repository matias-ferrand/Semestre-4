using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entities
{
    public class EJornalero: Empleado
    {
        public float horas { get; set; }
        public float precioHora { get; set; }
        public override void CalcularSueldo()
        {
            sueldo = horas * precioHora;
        }
    }
}
