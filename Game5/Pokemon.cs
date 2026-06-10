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

        public Pokemon(string name, string tipo, int atq, int def, int ps)
        {
            this.name = name;
            this.tipo = tipo;
            this.atq = atq;
            this.def = def;
            this.ps = ps;
        }

        public override string ToString()
        {
            return $"------------POKEMON------------\n" +
                   $"\n        Codigo: #0{code}\n" +
                   $"        Nombre: {name}\n" +
                   $"        Tipo:   {tipo}\n" +
                   $"\n--------------STATS----------------\n"+
                   $"\n     Atq: {atq} Def: {def}  PS: {ps}"+
                   $"\n-------------------------------------";
        }
    }
}
