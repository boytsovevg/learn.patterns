using System;
using ducks.bahavoir;

namespace ducks.fly
{
    public class FlyRocketPowered: IFlyable
    {
        public void FlyAction()
        {
            Console.WriteLine("I have got Elon Musk power!!! =====>");
        }
    }
}