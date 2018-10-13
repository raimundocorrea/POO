using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class Normal : TipoAtaque
    {
        int dano;

        public override int Attack(int ataqueBase, Habilidad habilidad)
        {
            string oper = habilidad.getOperAttack();
            if (oper == "+")
                return ataqueBase + habilidad.getAttack();
            else if (oper == "*")
                return ataqueBase * habilidad.getAttack();
            else if (oper == "/")
                return ataqueBase / habilidad.getAttack();
            else
                return ataqueBase - habilidad.getAttack();
        }

        public override void Habilility(Habilidad habilidad, Jugador j)
        {
            if (habilidad.getHabilidad() != 0)
            {
                foreach (Bitmon b in j.equipo)
                {
                    if (b.estaActivo)
                    {
                        b.estado += habilidad.getHabilidad();
                        break;
                    }
                }
            }
        }
    }
}
