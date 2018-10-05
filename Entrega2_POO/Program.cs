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
            /*serializacion de informacion precargada en programa - solo se corre 1 vez
            //Creacion de Bitmons
            Bitmon b1 = new Bitmon("Drago", 150, 300, 2, 75, 40);
            Bitmon b2 = new Bitmon("Jeti", 100, 450, 4, 35, 80);
            Bitmon b3 = new Bitmon("Katara", 150, 250, 3, 90, 30);
            Bitmon b4 = new Bitmon("Aang", 150, 250, 5, 90, 30);
            Bitmon b5 = new Bitmon("Pikatsu", 130, 275, 1, 90, 30);
            Bitmon b6 = new Bitmon("Toph", 100, 250, 4, 100, 40);
            Bitmon b7 = new Bitmon("Cthulhu", 80, 450, 3, 60, 80);
            Bitmon b8 = new Bitmon("Nattramn", 100, 100, 1, 120, 40);
            Bitmon b9 = new Bitmon("Ozzy", 100, 350, 2, 100, 30);
            Bitmon b10 = new Bitmon("Buzz", 120, 250, 5, 80, 50);

            FileStream fileStream = new FileStream("datos1", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Bitmon> bitmons = new List<Bitmon>() { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10 };
            binaryFormatter.Serialize(fileStream, bitmons);
            fileStream.Close();
            //System.Windows.Forms.Application.Exit(); //exit para app
            System.Environment.Exit(1); //exit para consola
            */
            //fin serializacion

            //deserializacion
            if (File.Exists("datos1"))
            {
                FileStream fs = new FileStream("datos1", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object deserializado = binaryFormatter.Deserialize(fs);
                List<Bitmon> bitmons = (List<Bitmon>)deserializado;
                foreach (Bitmon b in bitmons)
                    Console.WriteLine(b);
                Console.WriteLine("Estos son todos los Bitmons");
            }
            else
            {
                Console.WriteLine("Hubo un error con la lectura de los archivos");
                Console.WriteLine("Porfavor escriba en las lineas 17 y 37: //");
                Console.WriteLine("Con eso el programa volvera a guardar los datos para el juego");
                Console.WriteLine("Quite los: // en las lineas 17 y 37");
                Console.WriteLine("Gracias por su comprencion");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

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
            
        }
    }
}
