using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicoABC
{
    public class TestingDeC
    {
        public static void main(String[] args)
        {

            ClaseC unC = new ClaseC();

            int valor = unC.MetodoA("ABCZ");

            string dato = unC.MetodoB(valor);

        }
    }
}