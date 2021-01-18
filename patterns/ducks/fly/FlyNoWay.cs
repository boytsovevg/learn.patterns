using System;
using ducks.bahavoir;

namespace ducks.fly
{
    public class FlyNoWay: IFlyable
    {
        public void FlyAction()
        {
            Console.WriteLine("I can not fly :(");
        }
    }
}