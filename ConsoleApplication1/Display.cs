using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Display
    {
        public static void  DisplayPlayers (Players[] players)
        {
            
            Console.WriteLine("Játékos\t\tIdő");
            foreach (var player in players)
            {
                Console.WriteLine($"{player.Id}\t\t{player.Minutes}");
            }
            Console.ReadLine();

        }
        
    }

}
