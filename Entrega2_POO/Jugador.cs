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
        public List<Bitmon> equipo;
        int jugada;
        int tipoAtaque;
        bool EsTuTurno = false;
        Bitmon bitmomActivo;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            equipo[0].estaActivo = true;
        }

        public void CambiarBitmom(Bitmon bitmomActivo)
        {
            for (int i = 0; i < 3; i++)
            {
                if (equipo[i].estaActivo == true) { equipo[i].estaActivo = false; }
            }

            bitmomActivo.estaActivo = true;
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
            Console.WriteLine("Que movimiento deseas hacer {0}?:\n [1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms \n [4] Guardar Partida ");
            ElegirJugada(4);

            //[1] Cambiar Bitmom activo \n [2] Atacar \n [3] Ver info Bitmoms \n Descansar
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
            }
            else if (jugada == 2)
            {
                equipo[jugada].Ataque();
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
        }
        public bool KO()
        {
            if (equipo[0].estaVivo() && (equipo[1].estaVivo() && equipo[2].estaVivo()))
            {
                return true;
            }
            return false;
        }
    }
}