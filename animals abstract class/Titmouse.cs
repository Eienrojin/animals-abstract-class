using System;

namespace animals_abstract_class
{
    internal class Titmouse : Bird
    {
        public Titmouse(string name, int age, int weight) : base(name, age, weight)
        {
        }

        public Titmouse()
        {
        }

        public override void Breath()
        {
            Console.WriteLine("Синица дышит");
        }

        public override void Eat()
        {
            Console.WriteLine("Синица ест");
        }

        public override void Fly()
        {
            Console.WriteLine("Синица летит");
        }

        public override void Move()
        {
            Console.WriteLine("Синица движется");
        }
    }
}
