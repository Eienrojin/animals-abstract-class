using System;

namespace animals_abstract_class
{
    internal class Bird : Animals
    {
        public Bird(string name, int age, int weight) : base(name, age, weight)
        {
        }

        public Bird()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Птица ест");
        }

        public override void Move()
        {
            Console.WriteLine("Птица идёт");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Птица летит");
        }

        public override void Breath()
        {
            Console.WriteLine("Птица дышит");
        }
    }
}
