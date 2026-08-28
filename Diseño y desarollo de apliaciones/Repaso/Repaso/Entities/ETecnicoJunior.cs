using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entities
{
    public class ETecnicoJunior: ETecnico
    {
        public ETecnicoJunior()
        {
            grado = Grado.junior;
        }
    }
}
