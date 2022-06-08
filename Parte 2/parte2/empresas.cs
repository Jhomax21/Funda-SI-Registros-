using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte2
{
    public class empresas
    {
        private string ruc;
        private string nombre;
        private string direccion;

        public string Ruc { get => ruc; set => ruc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public empresas(string ruc, string nombre, string direccion)
        {
            this.ruc = ruc;
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
