using System;

namespace animals_abstract_class
{
    internal class Lion : Animals
    {
        public Lion(string name, int age, int weight) : base(name, age, weight)
        {
        }

        public Lion()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Лев ест");
        }

        public override void Move()
        {
            Console.WriteLine("Лев бежит");
        }

        public override void Breath()
        {
            Console.WriteLine("Лев дышит");
        }
    }
}
