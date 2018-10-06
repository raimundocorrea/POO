using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class poderFuego
    {
        List<string> nombreFuego;
        List<int> danoFuego;
        List<int> habilidadFuego1;
        List<int> habilidadFuego2;

        public string getPoder(int i)
        {
            return nombreFuego[i];
        }

        public int Ataque(int i, int ataqueBase)
        {
            if (i == 1)
            {
                return danoFuego[i] + ataqueBase;
            }
            return danoFuego[i] * ataqueBase;
        }

        public string getHabilidad(int i)
        {
            return habilidadFuego1[i] + " " + habilidadFuego2[i];
        }
    }
}
