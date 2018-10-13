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
    class Program
    {
        static void Main(string[] args)
        {
            //serializacion de informacion precargada en programa - solo se corre 1 vez


            //Creacion de Bitmons
            Bitmon b1 = new Bitmon("Drago", 150, 300, "Fuego", 75, 40);
            Bitmon b2 = new Bitmon("Jeti", 100, 450, "Tierra", 35, 80);
            Bitmon b3 = new Bitmon("Katara", 150, 250, "Agua", 90, 30);
            Bitmon b4 = new Bitmon("Aang", 150, 250, "Aire", 90, 30);
            Bitmon b5 = new Bitmon("Pikatsu", 130, 275, "Trueno", 90, 30);
            Bitmon b6 = new Bitmon("Toph", 100, 250, "Tierra", 100, 40);
            Bitmon b7 = new Bitmon("Cthulhu", 80, 450, "Agua", 60, 80);
            Bitmon b8 = new Bitmon("Nattramn", 100, 100, "Trueno", 120, 40);
            Bitmon b9 = new Bitmon("Ozzy", 100, 350, "Fuego", 100, 30);
            Bitmon b10 = new Bitmon("Buzz", 120, 250, "Aire", 80, 50);
            List<Bitmon> bitmons = new List<Bitmon>() { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 };



            FileStream fileStream = new FileStream("datos1", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, bitmons);
            fileStream.Close();
            Console.ReadLine();
            //System.Windows.Forms.Application.Exit(); //exit para app
            System.Environment.Exit(1); //exit para consola
            //fin serializacion

            /*
            //deserializacion
            List<Bitmon> bitmons = new List<Bitmon>();
            if (File.Exists("datos1"))
            {
                FileStream fs = new FileStream("datos1", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object deserializado = binaryFormatter.Deserialize(fs);
                List<Bitmon>  bit = (List<Bitmon>) deserializado;
                foreach (Bitmon b in bit)
                {
                    bitmons.Add(b);
                }
            }
            else
            {
                Console.WriteLine("Hubo un error con la lectura de los archivos");
                Console.WriteLine("Porfavor escriba en las lineas 17 y 37: //");
                Console.WriteLine("Corra nuevamente el programa, este se cerrara al instante");
                Console.WriteLine("Con eso el programa volvera a guardar los datos para el juego");
                Console.WriteLine("Quite los: // en las lineas 17 y 37");
                Console.WriteLine("Luego de esto el programa debiera funcionar correctamente");
                Console.WriteLine("Gracias por su comprencion");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            */
            Console.WriteLine("Bienvenidos a BATALLAS BITMON!!");
            Console.WriteLine("Este es un juego de combates por turnos 1v1");
            Console.WriteLine("Cada jugador deberá escoger un equipo de 3 Bitmon para salir a luchar");
            Console.WriteLine("Ganará el jugador que logre vencer a todos los Bitmon rivales");
            string player1;
            string player2;
            while (true)
            {
                Console.WriteLine("Player 1, ingrese su nombre:");
                player1 = Console.ReadLine();
                Console.WriteLine("Player 2, ingrese su nombre:");
                player2 = Console.ReadLine();
                if (player1 == player2)
                {
                    Console.WriteLine("Oh!, es muy complicado para mi ser juez de rivales indistinguibles");
                    Console.WriteLine("Deberan ingresar nuevamente sus nombres");
                }
                break;
            }
            Jugador p1 = new Jugador(player1);
            Jugador p2 = new Jugador(player2);
            Random rnd = new Random();
            List<Jugador> jugadores;
            int orden = rnd.Next(1, 2);
            if (orden == 1)
                jugadores = new List<Jugador>() { p1, p2 };
            else
                jugadores = new List<Jugador>() { p2, p1 };

            Console.WriteLine("El orden sorteado es el siguiente:");
            Console.WriteLine("Inicia el jugador: {0}\n Luego va el jugador: {1}", jugadores[0], jugadores[1]);
            int k = 0;
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Jugador {0} escoja el Bitmon", jugadores[k]);
                int j = 1;
                foreach (Bitmon bi in bitmons)
                {
                    Console.WriteLine(j);
                    bi.VerInfoBitmom();
                    j += 1;
                }
                Console.WriteLine("Ingrese en numero del Bitmon que decee escoger");
                jugadores[k].ElegirJugada(10);
                jugadores[k].agregarBitmon(bitmons[jugadores[k].jugada]);
                if (k == 0)
                {
                    k = 1;
                }
                else
                    k = 0;
            }
            while (p1.KO() || p2.KO())
            {
                jugadores[k].EsTuTurno = true;
                if (k == 0)
                {
                    jugadores[1].EsTuTurno = false;
                    jugadores[k].Estrategia();
                }
                else
                {
                    jugadores[0].EsTuTurno = false;
                    jugadores[k].Estrategia();
                }
                if (k == 0)
                {
                    k = 1;
                    continue;
                }
                k = 0;
            }
        }
    }
}
