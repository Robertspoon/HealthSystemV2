using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            Console.WriteLine("Health System Version 2");
            Console.WriteLine();
            player.ShowHUD();
            Console.WriteLine();
            player.TakeDamage(105);
            player.ShowHUD();
            Console.WriteLine();
            player.TakeDamage(-1000);
            player.ShowHUD();
            Console.WriteLine();
            player.RegenShields(200);
            player.ShowHUD();
            Console.WriteLine();
            player.RegenShields(-1000);
            player.ShowHUD();
            Console.WriteLine();
            player.Heal(100);
            player.ShowHUD();


            Console.ReadKey(true);
        }
    }
}
