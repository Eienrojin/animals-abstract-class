using System;

namespace animals_abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Карасик", 15, 120);
            Dolphin dolphin = new Dolphin("Плавничок", 10, 200);
            Bird someBird = new Bird("Птица", 14, 1);
            Titmouse titmouse = new Titmouse("Синичка", 2, 1);
            Titmouse voidTitmouse = new Titmouse();

            Console.WriteLine(lion);
            Console.WriteLine(dolphin);
            Console.WriteLine(someBird);
            Console.WriteLine(titmouse);
            Console.WriteLine(voidTitmouse);
        }
    }
}
