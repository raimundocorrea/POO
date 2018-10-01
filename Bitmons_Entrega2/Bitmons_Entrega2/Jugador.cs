using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons_Entrega2
{
    class Jugador
    {
        public string nombre;
        List<Bitmon> Bitmoms;
        int jugada = 0;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public void agregarBitmon(Bitmon bitmon)
        {
            equipo.Add(bitmon);
        }

        private void verEquipo()    
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(Bitmoms[i].VerInfoBitmom);
            }
        }

        private void verRival()
        {

        }

        private void verBitmons()
        {

        }

        public void Estrategia(int e)
        {

        }
    }
}
