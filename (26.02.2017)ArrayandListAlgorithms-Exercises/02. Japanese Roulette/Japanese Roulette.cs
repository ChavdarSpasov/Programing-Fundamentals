using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinderOfTheRevolver= Console.ReadLine().Split();           
            var playersAndStrenght = Console.ReadLine().Split();

            var positionOfTheBullet = 0;  
            for (int i = 0; i < cylinderOfTheRevolver.Length; i++)
            {
                if (cylinderOfTheRevolver[i] == "1")
                {
                    positionOfTheBullet = i;
                    break;
                }
            }

            bool playerDead = false;
            var playerIndex = 0;
                       
            for (int i = 0; i < playersAndStrenght.Length; i++)
            {
                var currPS = playersAndStrenght[i].Split(',');
                var direction = currPS[1];
                var strenght = int.Parse(currPS[0]);

                switch (direction)
                {
                    case "Left":
                        positionOfTheBullet = (positionOfTheBullet - strenght) % cylinderOfTheRevolver.Length ;
                        if (positionOfTheBullet < 0)
                        {
                            positionOfTheBullet = positionOfTheBullet + cylinderOfTheRevolver.Length;
                        }

                        break;
                    case "Right":
                        positionOfTheBullet = (positionOfTheBullet + strenght) % cylinderOfTheRevolver.Length ;
                        break;
                }
                

                if (positionOfTheBullet  == 2)
                {
                    playerDead = true;
                    playerIndex = i;
                    break;
                }

                positionOfTheBullet++;
            }


            if (playerDead)
            {
                Console.WriteLine($"Game over! Player {playerIndex} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
