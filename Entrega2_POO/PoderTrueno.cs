using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Entrega2_POO
{
    class PoderTrueno
    {
        List<string> nombreTrueno;
        List<int> danoTrueno;
        List<string> habilidadTrueno1;
        List<int> habilidadTrueno2;

        public string getPoder(int i)
        {
            return nombreTrueno[i];
        }

        public int Ataque(int i, int ataqueBase)
        {
            if (i == 1)
            {
                return danoTrueno[i] + ataqueBase;
            }
            return danoTrueno[i] * ataqueBase;
        }

        public string getHabilidad(int i)
        {
            return habilidadTrueno1[i]+" "+habilidadTrueno2[i];
        }
    }
}
