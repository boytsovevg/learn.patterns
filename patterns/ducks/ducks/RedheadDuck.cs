using ducks.fly;
using ducks.quack;

namespace ducks.ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base("RedheadDuck", new FlyWithWings(), new Quack())
        {
        }
    }
}