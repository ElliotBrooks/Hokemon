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

            Console.WriteLine("{0}: waits...", attacker.name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0}: and waits...", attacker.name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: 'I Accept The Challenger!!!'", defender.name);
            
            Console.WriteLine("*** Contender Stats ***");
            attacker.get_details();
            defender.get_details();

            Console.WriteLine("*** BATTLE BEGINS ***\n");

            while (Convert.ToInt32(defender.health) >= 0 || Convert.ToInt32(attacker.health) >= 0)
            {
                roundNum = roundNum + 1;
                attackNum = attacker.attackCalculator();
                defenceNum = defender.defenceCalculator();
            }
        }

    }
}
