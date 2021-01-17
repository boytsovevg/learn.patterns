using System;
using ducks.bahavoir;

namespace ducks.ducks
{
    public class MallardDuck: Duck, IFlyable, IQuackable
    {
        public MallardDuck(): base("Mallard Duck")
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name}: I can Fly");
        }

        public void Quack()
        {
            Console.WriteLine($"{this.Name}: QUAAACK!");
        }
    }
}