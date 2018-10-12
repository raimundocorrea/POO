using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    [Serializable()]
    abstract class TipoAtaque
    {
        public List<Habilidad> habilidades;

        public abstract int Attack(int ataqueBase, Habilidad habilidad);

        public abstract void Habilility(Habilidad habilidad, Jugador j);

        public void getHabilidades(string naturaleza)
        {
            foreach (Habilidad h in habilidades)
            {
                if (h.naturaleza == naturaleza)
                    h.verHabilidad();
            }
        }
    }
}
