using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Lab
{
    class Album
    {
        private string nombre;
        private string codigoalbum;
        private List<Heroe> heroes;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigoalbum { get => codigoalbum; set => codigoalbum = value; }
        internal List<Heroe> Heroes { get => heroes; set => heroes = value; }

        public Album(string nombrealbum, string codigoalbum, List<Heroe> heroes)
        {
            this.Nombre = nombrealbum;
            this.Codigoalbum = codigoalbum;
            this.Heroes = heroes;
        }
    }
}
