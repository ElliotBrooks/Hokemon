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

            hoke01.get_details();

            //INSANTIATE a second Hokemon

                


        }
    }
}
