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
    class Especial : Naturaleza
    {
        protected override int Attack(int ataqueBase, Habilidad habilidad)
        {
            return 1;
        }

        protected override void Habilility()
        {
            
        }
    }
}
