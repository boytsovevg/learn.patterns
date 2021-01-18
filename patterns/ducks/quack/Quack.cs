using System;
using ducks.bahavoir;

namespace ducks.quack
{
    public class Quack: IQuackable
    {
        public void QuackAction()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}