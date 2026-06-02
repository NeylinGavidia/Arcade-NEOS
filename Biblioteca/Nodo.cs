using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Nodo
    {
        public Nodo dato; //pongo el standar pero de aqui cada uno debe agregar otro dato a su conveniencia por ejmeplo punlic Persona dato;
        public Nodo iz, de, sig, ant = null; //pongo lo que me acuerdo izquierda, derecha, siguiente y anterior
    }
}
