using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoABC
{
    public class ClaseC: ClaseA
    {
        public ClaseB unB;

        public string MetodoB(int i)
        {
            return unB.MetodoB(i);
        }
    }
}
