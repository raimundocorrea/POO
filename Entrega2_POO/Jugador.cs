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
    [Serializable()]
    class Jugador
    {
        public string nombre;
        List<Bitmon> equipo;
        public int jugada;
        bool EsTuTurno = false;
        Bitmon bitmomActivo;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            bitmomActivo = equipo[0];
        }

        public void CambiarBitmom(Bitmon bb)
        {
            bitmomActivo = bb;
        }

        public void estadoEquipo()
        {
            foreach (Bitmon b in equipo)
            {
                if (b.estaVivo() && b.estado > 0)
                {
                    b.CambiarVida(5);
                    b.estado -= 1;
                }
                else if (b.estaVivo() && b.estado < 0)
                {
                    b.CambiarVida(-5);
                    b.estado += 1;
                }
            }
        }

        public void agregarBitmon(Bitmon bitmon)
        {
            equipo.Add(bitmon);
        }

        private void verEquipo()
        {
            for (int i = 0; i < 3; i++)
            {
                equipo[i].VerInfoBitmom();
            }
        }

        public void ElegirJugada(int NumOpciones)
        {
            bool error = true;
            while (error)
            {
                try
                {
                    jugada = int.Parse(Console.ReadLine());
                    error = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Debe ingresar una opcion numerica!!");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if ((jugada > NumOpciones) || (jugada <= 0))
                    {
                        error = true;
                        Console.WriteLine("Opcion no valida, ingrese nuevamente.");
                    }
                }
            }
        }
        // Es el metodo que permite al jugador elegir que hacer en el juego
        public void Estrategia()
        {
            Console.WriteLine("Que movimiento deseas hacer {0}?:\n [1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms \n [4] Guardar Partida \n [5] Descansar Bitmon");
            ElegirJugada(5);

            //[1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms \n [4] Guardar partida \n [5] Descansar
            if (jugada == 1)
            {
                Console.WriteLine("Indique el bitmom que desea utilizar: ");
                verEquipo();    //muestra la info del equipo
                ElegirJugada(3);
                while (equipo[jugada].estaVivo() == false)
                {
                    Console.WriteLine("El Bitmom {0} ya esta muerto ", equipo[jugada]);
                    Console.WriteLine("seleccione nuevamente");
                    ElegirJugada(3);
                }
                Console.WriteLine("Has seleccionado el Bitmom {0}", equipo[jugada]);
                bitmomActivo = equipo[jugada];
            }
            else if (jugada == 2)/////////////////////////////////////////////////////////////7
            {
                TipoAtaque.getHabilidades(bitmomActivo.getNaturaleza());
                ElegirJugada(2);
                int habilidad1 = 0;
                foreach(Habilidad h in TipoAtaque.habilidades)//selecciono la posicion de la habilidad escogida dentro de lista de habilidades
                {
                    if (jugada == 1 && h.naturaleza == bitmomActivo.getNaturaleza())
                    {
                        jugada = habilidad1;
                        break;
                    }
                    if (h.naturaleza == bitmomActivo.getNaturaleza())
                    {
                        jugada -= 1;
                    }
                    habilidad1 += 1;
                }
                if (TipoAtaque.habilidades[jugada].getTipo())
                {
                    TipoAtaque n = new Normal();
                    bitmomActivo.Ataque(n, TipoAtaque.habilidades[jugada]);
                }
                else
                {
                    TipoAtaque e = new Especial();
                    bitmomActivo.Habilidad(e);
                }
                    
            }
            else if (jugada == 3)
            {
                verEquipo();
            }
            else if (jugada == 4)
            {
                Console.WriteLine("Guardar partida");// FALTA POR HACER
                //Guardar partida
            }
            else if (jugada == 5)
            {
                bitmomActivo.Descansar();
            }

            foreach(Bitmon bb in equipo)
            {
                if (bb.estado > 0)//reducir vida
                {
                    bb.CambiarVida(5);
                    bb.estado -= 1;
                }
                else if (bb.estado < 0)//aumentar vida
                {
                    bb.CambiarVida(-5);
                    bb.estado += 1;
                }

            }
        }

        public bool KO()
        {
            if (equipo[0].estaVivo() && (equipo[1].estaVivo() && equipo[2].estaVivo()))
            {
                return false;
            }
            return true;
        }
    }
}