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
        int stamina;//int[] stamina;
        int vida;
        string naturaleza;//1-trueno, 2-fuego, 3-agua, 4-tierra, 5-aire
        int AttackBase;
        int DefBase;
        public int estado = 0;//corresponde al contador de turnos en que esta afectado por una habilidad

        public Bitmon(string nombre, int stamina, int vida, string naturaleza, int attack, int def)
        {
            this.nombre = nombre;
            this.stamina = stamina;//stamina = new int[2]{stamina1, stamina2}
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

        public void Ataque(TipoAtaque ataque, Habilidad habilidad, Jugador j)
        {
            if (habilidad.getGasto() <= stamina)
            {
                CambiarStamina(habilidad.getGasto());
                ataque.Attack(AttackBase, habilidad);
                ataque.Hability(habilidad, j.bitmonActivo());
            }
            else
                Console.WriteLine("No te alcanza la Stamina \n Perdiste tu turno");
        }

        public void Habilidad(TipoAtaque especial, Habilidad habilidad, List<Bitmon> equipo)
        {
            if (habilidad.getGasto() <= stamina)
            {
                CambiarStamina(habilidad.getGasto());
                foreach (Bitmon bb in equipo)
                {
                    if (bb.nombre == nombre)
                        continue;
                    bb.CambiarVida(especial.Attack(AttackBase, habilidad));
                    especial.Hability(habilidad, bb);
                }
            }
            else
                Console.WriteLine("No te alcanza la Stamina \n Perdiste tu turno");
            
        }
    }
}
