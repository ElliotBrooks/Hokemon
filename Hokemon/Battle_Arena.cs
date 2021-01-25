using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {

        public void requestAChallenger(Hokemon requestor)
        {
            Console.WriteLine("{0}: says 'I Want A Challenger!!!'", requestor.name);
        }

        public void theBattle(Hokemon attacker, Hokemon defender)
        {
            int roundNum = 0;
            int attackNum = 0;
            int defenceNum = 0;
            Hokemon tempHoke;

            Console.WriteLine("{0}: waits...", attacker.name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0}: and waits...", attacker.name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: 'I Accept The Challenger!!!'", defender.name);

            Console.WriteLine("--- Contender Stats ---");
            attacker.get_details();
            defender.get_details();

            Console.WriteLine("--- BATTLE BEGINS ---\n");

            while (Convert.ToInt32(defender.health) >= 0 || Convert.ToInt32(attacker.health) >= 0)
            {
                roundNum = roundNum + 1;
                attackNum = attacker.attackCalculator();
                defenceNum = defender.defenceCalculator();

                Console.WriteLine("---Round{0}---\n\n", roundNum);

                for (int i = 0; i < 2; i++)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("{0}: prepares to attack...", attacker.Name);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("{0}: attacks for:{1}...\n\n", attacker.Name, attackNum);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("{0}: prepares for the attack and build up its defence value to: {1}", defender.Name, defenceNum);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("{0}: was hurt for (HEALTH {1} + DEFENCE {2}) = {3} - ATTACK {4}\n", defender.Name, defender.health, defenceNum, (defender.health + defenceNum), attackNum);
                    defender.health = (defender.health + defenceNum) - attackNum;
                    Console.WriteLine("{0}: now has {1} health ", defender.Name, ((defender.health + defenceNum) - attackNum));

                    Console.WriteLine("\n-----------------------------\n");

                    Console.WriteLine("\n----\nSwitch turns Defender becomes the Attacker...\n----\n");
                    tempHoke = attacker;
                    attacker = defender;
                    defender = tempHoke;
                }
            }
            if (attacker.health > defender.health)
            {
                Console.WriteLine("{0}: WINS", attacker.Name);
            }
            else
            {
                Console.WriteLine("{0}: WINS", defender.Name);
            }
        }

    }
}