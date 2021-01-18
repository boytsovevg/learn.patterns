using ducks.fly;
using ducks.quack;

namespace ducks.ducks
{
    public class RubberDuck: Duck
    {
        public RubberDuck(): base("RubberDuck", new FlyNoWay(), new Squeak())
        {
        }
    }
}