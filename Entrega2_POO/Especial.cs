using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class Especial : TipoAtaque
    {
        public Especial()
        {

        }

        public override int Attack(int ataqueBase, Habilidad habilidad)
        {
            throw new NotImplementedException();
        }

        public override void Habilility(Habilidad habilidad, Jugador j)
        {
            throw new NotImplementedException();
        }
    }
}
