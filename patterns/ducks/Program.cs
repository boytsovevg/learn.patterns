using System;
using ducks.ducks;
using ducks.fly;
using ducks.quack;

namespace ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            
            mallard.Quack();
            mallard.SetQuackBehavior(new Squeak());
            Console.WriteLine("-- Change Quack Behavior --");
            mallard.Quack();

            Console.WriteLine("---------------------");
            
            var model = new ModelDuck("Model Duck");
            model.Fly();
            model.SetFlyBehavior(new FlyRocketPowered());
            Console.WriteLine("-- Change Quack Behavior --");
            model.Fly();

        }
    }
}