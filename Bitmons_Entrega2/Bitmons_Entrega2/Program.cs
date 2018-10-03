using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons_Entrega2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador p1 = new Jugador("pedro");
            p1.Estrategia();
            Console.Read();
            
        }
    }
}
