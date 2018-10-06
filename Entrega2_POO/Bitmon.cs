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
        int naturaleza;//1-trueno, 2-fuego, 3-agua, 4-tierra, 5-aire
        int AttackBase;
        int DefBase;
        public bool estaActivo = false;
        int estado = 0;

        public Bitmon(string nombre, int stamina, int vida, int naturaleza, int attack, int def)
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
            Console.WriteLine(" -Nombre : {0}\n -Stamina: {1}\n -Vida: {2}\n - Naturalera: {3}\n - Ataque: {4}\n - Defensa: {5}\n", nombre, stamina, vida, naturaleza, AttackBase, DefBase);
        }

        public void CambiarVida(Bitmon BitmomEnemigo)
        {
            vida -= Ataque();
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

        private int HabilidadEspecial()
        {
            return 1;
        }

        public int Descansar()
        {
            return 1;
        }

        public int Ataque()
        {
            return 1;
        }
    }
}
