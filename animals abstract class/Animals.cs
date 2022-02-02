using System;

namespace animals_abstract_class
{
    abstract internal class Animals
    {
        protected Animals(string name, int age, int weight)
        {
            Name=name;
            Age=age;
            Weight=weight;
        }

        public Animals()
        {
        }

        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual int Weight { get; set; }

        public abstract void Move();
        public abstract void Eat();
        public virtual void Breath()
        {
            Console.WriteLine("Дышит");
        }

        public override string ToString()
        {
            return $"Имя - {Name}\n Возраст - {Age}\n Вес - {Weight}";
        }
    }
}
