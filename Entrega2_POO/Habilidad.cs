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
        int efectoHabilidad;//cantidad de turnos en que se enferma a un bitmon
        bool tipoAtaque;//true: Normal, false: especial
        int gasto;
        string descrip;

        public Habilidad(string nombre, string naturaleza, int stamina, int dano, string oper1, int efect, bool tipo, string descrip)
        {
            this.nombre = nombre;
            this.naturaleza = naturaleza;
            gasto = stamina;
            danoAttack = dano;
            operadorAttack = oper1;
            efectoHabilidad = efect;
            tipoAtaque = tipo;
            this.descrip = descrip;
        }

        public void verHabilidad()
        {
            Console.WriteLine(" - Nombre : {0}\n - Descripcion: \n", nombre, );
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

        public int getGasto()
        {
            return gasto;
        }

        public bool getTipo()
        {
            return tipoAtaque;
        }
    }
}
