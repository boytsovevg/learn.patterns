using System;
using ducks.bahavoir;

namespace ducks.quack
{
    public class Squeak: IQuackable
    {
        public void QuackAction()
        {
            Console.WriteLine("*Squeeeeak*");
        }
    }
}