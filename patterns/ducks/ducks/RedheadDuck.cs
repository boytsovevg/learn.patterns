using System;
using ducks.bahavoir;

namespace ducks.ducks
{
    public class RedheadDuck : Duck, IFlyable, IQuackable

    {
    public RedheadDuck() : base("RedheadDuck")
    {
    }

    public void Fly()
    {
        Console.WriteLine($"{this.Name}: I can Fly");
    }

    public void Quack()
    {
        Console.WriteLine($"{this.Name}: *quacks quacks*!");
    }
    }
}