using ducks.fly;
using ducks.quack;

namespace ducks.ducks
{
    public class MallardDuck: Duck
    {
        public MallardDuck(): base("Mallard Duck", new FlyWithWings(), new Quack())
        {
        }
    }
}