using System;
using ducks.ducks;

namespace ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            RedheadDuck redhead = new RedheadDuck();
            RubberDuck rubber = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();
            
            mallard.Quack();
            redhead.Quack();
            rubber.Quack();
        }
    }
}