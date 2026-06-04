using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    public class Arbol5
    {
        private Nodo raiz_pri;

        static int cont = 0;

        public void Codigo(Pokemon d)
        {
            d.code = cont;
            cont++;
        }
    }
}
