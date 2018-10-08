using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    class Normal : Naturaleza
    {
        int dano;

        public Normal()
        {

        }

        protected override int Attack(int ataqueBase, Habilidad habilidad)
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

        protected override void Habilility()
        {

        }
    }
}
