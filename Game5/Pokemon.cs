using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    public class Pokemon
    {
        public string name;
        public int code;
        public string tipo;
        public int def;
        public int atq;
        public int ps;

        public Pokemon() { }

        public override string ToString()
        {
            return $"\n----------------------------\n" +
                   $"Codigo:          #0{code}\n" +
                   $"Nombre:          {name}\n" +
                   $"Tipo:            {tipo}\n" +
                   $"----------------------------\n";
        }
    }
}
