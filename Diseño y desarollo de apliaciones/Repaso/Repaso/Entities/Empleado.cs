using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entities
{
    public abstract class Empleado
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public float sueldo { get; set; }

        public virtual void CalcularSueldo()
        {
        }
    }
}
