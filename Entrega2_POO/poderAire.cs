using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class poderAire
    {
        List<string> nombreAire;
        List<int> danoAire;
        List<string> habilidadAire1;
        List<int> habilidadAire2;

        public string getPoder(int i)
        {
            return nombreAire[i];
        }

        public int Ataque(int i, int ataqueBase)
        {
            if (i == 1)
            {
                return danoAire[i] + ataqueBase;
            }
            return danoAire[i] * ataqueBase;
        }

        public string getHabilidad(int i)
        {
            return habilidadAire1[i] + " " + habilidadAire2[i];
        }
    }
}
