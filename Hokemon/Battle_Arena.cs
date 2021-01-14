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
            Console.WriteLine("{0}: waits...", attacker.name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0}: and waits...", attacker.name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: 'I Accept The Challenger!!!'", defender.name);
        }
    }
}
