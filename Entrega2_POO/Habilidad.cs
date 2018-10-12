using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2_POO
{
    [Serializable()]
    class Habilidad
    {
        public string nombre;
        public string naturaleza;
        int danoAttack;
        string operadorAttack;
        int efectoHabilidad;
        //string operadorHabilidad;

        public Habilidad(string nombre, TipoAtaque n, int dano, string oper1, int efect)//, string oper2)
        {
            this.nombre = nombre;
            naturaleza = n;
            danoAttack = dano;
            operadorAttack = oper1;
            efectoHabilidad = efect;
            //operadorHabilidad = oper2;
        }

        public void verHabilidad()
        {
            Console.WriteLine(" - Nombre : {0}\n - Naturaleza: {1}\n - Ataque: AtaqueBase{2}{3}\n - Efecto por {4} turnos\n", nombre, naturaleza, operadorAttack, danoAttack, efectoHabilidad);
        }

        public int getAttack()
        {
            return danoAttack;
        }

        public string getOperAttack()
        {
            return operadorAttack;
        }

        public int getHabilidad()
        {
            return efectoHabilidad;
        }
        /*
        public string getOperHabilidad()
        {
            return operadorHabilidad;
        }*/
    }
}
