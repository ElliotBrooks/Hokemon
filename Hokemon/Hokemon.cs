using System;

namespace Hokemon
{
    class Hokemon
    {
        // Hokemon attributes
        public string name;
        public int health;
        public int max_health;
        public int attack;
        public int speed;
        public int defence;

        // Below is my CONSTRUCTOR
        public Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defence = random_int_generator(10, 100);

        }
        
        public void definition()
        {
            Console.WriteLine("I am {0} a member of the hokemon tribe!!", name);
        }

        public string Name
        {
           get { return name; }
           set { name = value; }
        }

        public void get_details()
        {
            Console.WriteLine("Name:{0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed {4}\nDefence: {5} ", name, health, max_health, attack, speed, defence);
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        private int random_int_generator(int min_value, int max_value) // PARAMETERS int min_value, int max_value
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public int attackCalculator()
        {
            int attackValue;
            Random rnd = new Random();

            attackValue = ((attack * speed) / 2) * rnd.Next(0, 2);

            return attackValue;
        }

        public int defenceCalculator()
        {
            int defenceValue;
            Random rnd = new Random();

            defenceValue = (defence * speed) / 10 * rnd.Next(0, 2);

            return defenceValue;
        }
        
    }
}