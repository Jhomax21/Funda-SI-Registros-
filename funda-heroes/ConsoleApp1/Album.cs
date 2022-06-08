using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Album
    {
        public string Nombre;
        public string Codigoalbum;
        public List<Heroe> Heroes;

        public Album (string nombrealbum, string codigoalbum, List<Heroe> heroes)
        {
            this.Nombre = nombrealbum;
            this.Codigoalbum = codigoalbum;
            this.Heroes = heroes;
        }
    }
}
