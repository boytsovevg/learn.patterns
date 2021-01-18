using System;
using ducks.bahavoir;

namespace ducks.fly
{
    public class FlyWithWings: IFlyable
    {
        public void FlyAction()
        {
            Console.WriteLine("I Fly with wings");
        }
    }
}