using System;

namespace animals_abstract_class
{
    internal class Dolphin : Animals
    {
        public Dolphin(string name, int age, int weight) : base(name, age, weight)
        {
        }

        public Dolphin()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Дельфин ест");
        }

        public override void Move()
        {
            Console.WriteLine("Дельфин плавает");
        }

        public override void Breath()
        {
            Console.WriteLine("Дельфин дышит");
        }
    }
}
