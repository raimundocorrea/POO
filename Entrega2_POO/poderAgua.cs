using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class poderAgua
    {
        List<string> nombreAgua;
        List<int> danoAgua;
        List<int> habilidadAgua1;
        List<int> habilidadAgua2;

        public string getPoder(int i)
        {
            return nombreAgua[i];
        }

        public int Ataque(int i, int ataqueBase)
        {
            if (i == 1)
            {
                return danoAgua[i] + ataqueBase;
            }
            return danoAgua[i] * ataqueBase;
        }

        public string getHabilidad(int i)
        {
            return habilidadAgua1[i] + " " + habilidadAgua2[i];
        }
    }
}
