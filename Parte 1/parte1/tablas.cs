using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parte1
{
    class tablas
    {
        private Array tabla1 = Array.CreateInstance(typeof(String), 2);
        private Array tabla2 = Array.CreateInstance(typeof(String), 4);

        public Array Getab1()
        {
            return tabla1;
        }
        public Array Gettab1()
        {
            return tabla1;
        }
        public Array Gettab2()
        {
            return tabla2;
        }

        public void settab1(Array value)
        {
            tabla1 = value;
        }
        public void settab2(Array value)
        {
            tabla2 = value;
        }

        public void llenarArreglos()

        {
            String[] tabla1 = new string[2];
            tabla1[0] = "E - Electrico";
            tabla1[1] = "M - Manual";
            settab1(tabla1);
            String[] tabla2 = new string[4];
            tabla2[0] = "1 - 11km - s/ 5";
            tabla2[1] = "2 - 19km - s/ 12";
            tabla2[2] = "3 - 31km - s/ 20";
            tabla2[3] = "4 - free - s/ 40";
            settab2(tabla2);
        }

        public double aumentarprecio(bool tipo, double costoinicial)
        {

            if (tipo)
            {
                double monto;
                monto = costoinicial * 0.25;
                costoinicial = costoinicial + monto;
            }
            return costoinicial;

        }

    }
}
