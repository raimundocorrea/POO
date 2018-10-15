using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class Especial : TipoAtaque
    {
        public override int Attack(int ataqueBase, Habilidad habilidad)
        {
            return habilidad.getAttack();//ojo que esto puede hacer que se sobrepase la vida inicial
        }

        public override void Hability(Habilidad habilidad, Bitmon bb)
        {
            throw new NotImplementedException();
        }
    }
}
