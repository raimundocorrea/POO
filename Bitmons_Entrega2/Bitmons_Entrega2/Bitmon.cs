using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmons_Entrega2
{
    class Bitmon
    {
        string nombre;
        int stamina;
        int vida;
        int naturaleza;
        int AttackBase;
        int DefBase;
        public bool estaActivo = false;



        public Bitmon(string nombre, int stamina, int vida, int naturaleza, int attack, int def)
        {
            this.nombre = nombre;
            this.stamina = stamina;
            this.vida = vida;
            this.naturaleza = naturaleza;
            AttackBase = attack;
            DefBase = def;
        }

        public void  VerInfoBitmom(){
            
            Console.WriteLine(" -Nombre : {0}\n -Stamina: {1}\n -Vida: {2} - Naturalera: {3} - Ataque: {4} - Defensa: {5} ", nombre, stamina, vida, naturaleza, AttackBase, DefBase); 
            
        }

        public void CambiarVida(Bitmon BitmomEnemigo){
        
            vida = vida - Ataque();

        }


       

        public int Ataque(IAtacarFuego tipoAtaque){
        }                                                   



            
        }
        

        

        



    
}
