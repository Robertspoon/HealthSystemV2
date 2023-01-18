using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{

    internal class Player
    {
        //fields
        private int health;
         private int shields;
         private int lives;

        //method

        public Player()//constructor
        {
            health = 100;
            shields = 100;
            lives = 3;

        }

        public void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shields: " + shields);
            Console.WriteLine("Lives: " + lives);
        }

        public void TakeDamage(int hp)
        {
            Console.WriteLine("You are about to take " + hp +  " damage!");
            if(hp <0)
            {
                hp = 0;
                Console.WriteLine("You silly billy, you cant input negative numbers :p");
            }
            shields = shields - hp;
            if (shields <0)
            {
                health += shields;
                shields = 0;
            }
            if (health <0)
            {
                health = 0;
            }
        }

        public void Heal(int hp)
        {
            health = +hp;
            if (health >100)
            {
                health = 0;
            }
        }
        public void RegenShields(int regenShields)
        {
            if (regenShields <0)
            {
                regenShields = 0;
                Console.WriteLine("You cant do that you fool! Negative number is a no no :p");
            }
            shields += regenShields;
            if(shields >100)
            {
                shields = 100;
            }
        }



    }
}
