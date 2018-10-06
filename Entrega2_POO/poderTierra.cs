using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class poderTierra
    {
        List<string> nombreTierra;
        List<int> danoTierra;
        List<int> habilidadTierra1;
        List<int> habilidadTierra2;

        public string getPoder(int i)
        {
            return nombreTierra[i];
        }

        public int Ataque(int i, int ataqueBase)
        {
            if (i == 1)
            {
                return danoTierra[i] + ataqueBase;
            }
            return danoTierra[i] * ataqueBase;
        }

        public string getHabilidad(int i)
        {
            return habilidadTierra1[i] + " " + habilidadTierra2[i];
        }
    }
}
