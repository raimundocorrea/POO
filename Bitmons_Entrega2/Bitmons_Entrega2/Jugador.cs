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
        int jugada ;
        int tipoAtaque;
        bool EsTuTurno = false;
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

                
        public void Estrategia()    // Es el metodo que permite al jugador elegir que hacer en el juego
        {
            bool error = true;
            Console.WriteLine("Que movimiento deseas hacer {0}?:\n [1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms ");
            
            while(error){
            try{
                jugada = Convert.ToInt32(Console.Read());
                error = false;
                }
            catch (Exception e){
                Console.WriteLine(e.GetType);
                }



            }

            
        }
    }
}
