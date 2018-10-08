using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    abstract class Naturaleza
    {
        public List<Habilidad> habilidades;

        protected abstract int Attack(int ataqueBase, Habilidad habilidad);

        protected abstract void Habilility();

        public void getPoderes(Naturaleza n)
        {
            foreach(Habilidad h in habilidades)
            {
                if (h.naturaleza == n)
                {
                    h.verHabilidad();
                }
            }
        }
    }
}
