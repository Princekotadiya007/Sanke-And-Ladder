using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0;
            int player2 = 0;

            Random random = new Random();              //player1

            int check = random.Next(1, 7);
            Console.WriteLine("player1 roll {0}", check);

            int die1 = random.Next(0, 3);

            if(check==0)
            {
                Console.WriteLine("no playing");
            }
            if(die1==1)
            {
                player1 += check;
                Console.WriteLine("player1 step ladder", die1);
            }
            else
            {
                player1 -= check;
                Console.WriteLine("it sanke step down", player1);
            }
            //player2
            Random random1 = new Random();
            int check2 = random1.Next(1, 7);
            Console.WriteLine("player2 roll {0}", check2);

            int die2 = random.Next(0, 3);

            if (check2 == 0)
            {
                Console.WriteLine("no playing");
            }
            if (die2 == 1)
            {
                player2 += check2;
                Console.WriteLine("player2 step ladder", player2);
            }
            else
            {
                player2 -= check2;
                Console.WriteLine("it sanke step down", player2);
            }
        }
    }
}
