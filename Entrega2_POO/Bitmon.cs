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
    class Bitmon
    {
        string nombre;
        int stamina;
        int vida;
        string naturaleza;//1-trueno, 2-fuego, 3-agua, 4-tierra, 5-aire
        int AttackBase;
        int DefBase;
        public int estado = 0;//corresponde al contador de turnos en que esta afectado por una habilidad

        public Bitmon(string nombre, int stamina, int vida, string naturaleza, int attack, int def)
        {
            this.nombre = nombre;
            this.stamina = stamina;
            this.vida = vida;
            this.naturaleza = naturaleza;
            AttackBase = attack;
            DefBase = def;
        }

        public void VerInfoBitmom()
        {
            Console.WriteLine(" - Nombre : {0}\n - Stamina: {1}\n - Vida: {2}\n - Naturalera: {3}\n - Ataque: {4}\n - Defensa: {5}\n", nombre, stamina, vida, naturaleza, AttackBase, DefBase);
        }

        public string getNaturaleza()
        {
            return naturaleza;
        }

        public void CambiarEstado(int cambio)
        {
            estado += cambio;
        }

        public void CambiarVida(int cambio)
        {
            vida -= cambio;
        }

        public void CambiarStamina(int gasto)
        {
            stamina -= gasto;
        }

        public bool estaVivo()
        {
            if (vida > 0)
                return true;
            return false;
        }

        public void Descansar()
        {
            stamina += 20;
            vida += 5;
        }

        public void Ataque(TipoAtaque ataque)
        {
            ataque.getHabilidades(naturaleza);
            /*
            Console.WriteLine("Que ataque decea hacer?");
            naturaleza.getPoderes();
            j1.ElegirJugada(3);
            foreach (Bitmon b in j2.equipo)
            {
                if (b.estaActivo)
                {
                    b.vida -= j1.bitmomActivo.naturaleza.Attack(j1.bitmomActivo.AttackBase, j1.bitmomActivo.naturaleza.habilidades[j1.jugada]);
                    j1.bitmomActivo.naturaleza.Habilility(j1.bitmomActivo.naturaleza.habilidades[j1.jugada], j2);
                } 
            }*/
        }

        public void Habilidad(TipoAtaque habilidad)
        {

        }
    }
}
