using ducks.fly;
using ducks.quack;

namespace ducks.ducks
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck() : base("DecoyDuck", new FlyWithWings(), new MuteQuack())
        {
        }
    }
}