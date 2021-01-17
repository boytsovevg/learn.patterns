using System;
using ducks.bahavoir;

namespace ducks.ducks
{
    public class RubberDuck: Duck, IQuackable
    {
        public RubberDuck(): base("RubberDuck")
        {
            
        }

        public void Quack()
        {
            Console.Write($"{this.Name}: --Quack--");
        }
    }
}