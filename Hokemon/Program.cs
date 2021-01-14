using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Hokeworld, home of the hokemon!");

            //instanation of new Hokemon

            Hokemon hoke01 = new Hokemon(); // INSATNTIATE new hokemon object refered to as hoke01

            Console.WriteLine("Name: {0}", hoke01.name);
            Console.WriteLine("Attack: {0}", hoke01.attack);
            Console.WriteLine("Defence: {0}", hoke01.defence);

            hoke01.get_details();

            //INSANTIATE a second Hokemon

            Hokemon hoke02 = new Hokemon();

            Console.WriteLine("Name: {0}", hoke02.name);
            Console.WriteLine("Attack: {0}", hoke02.attack);
            Console.WriteLine("defence: {0}", hoke02.defence);
            hoke02.get_details();

            Hokemon hokemonObject = new Hokemon();

            hokemonObject.get_details();
            Console.WriteLine("Attack value is: {0}", hokemonObject.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hokemonObject.defenceCalculator());

            Battle_Arena newBattleObject = new Battle_Arena();
            newBattleObject.requestAChallenger(hoke02);



        }
    }
}
