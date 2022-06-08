using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Lab
{
    class Heroe
    {
        private string nombreheroe;
        private string codigoheroe;
        private string caracteristicas;
        private int poder;

        public string Nombreheroe { get => nombreheroe; set => nombreheroe = value; }
        public string Codigoheroe { get => codigoheroe; set => codigoheroe = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public int Poder { get => poder; set => poder = value; }

        public Heroe(string nombreheroe, string codigoheroe, string caracteristicas, int poder)
        {
            this.Nombreheroe = nombreheroe;
            this.Codigoheroe = codigoheroe;
            this.Caracteristicas = caracteristicas;
            this.Poder = poder;
        }
    }
}
