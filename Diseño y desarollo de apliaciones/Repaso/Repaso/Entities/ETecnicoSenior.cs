using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso.Entities;

namespace Repaso.Entities
{
    public class ETecnicoSenior : ETecnico
    {
        public ETecnicoSenior()
        {
            grado = Grado.senior;
        }
    }
}
