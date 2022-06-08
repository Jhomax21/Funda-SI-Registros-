using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Heroe
    {
       public string Nombreheroe;
        public string Codigoheroe;
        public string Caracteristicas;
        public int Poder;

        public Heroe(string nombreheroe, string codigoheroe, string caracteristicas, int poder)
        {
            this.Nombreheroe = nombreheroe;
            this.Codigoheroe = codigoheroe;
            this.Caracteristicas = caracteristicas;
            this.Poder = poder;
        }
    }
}
