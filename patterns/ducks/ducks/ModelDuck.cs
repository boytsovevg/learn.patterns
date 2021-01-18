using ducks.bahavoir;
using ducks.fly;
using ducks.quack;

namespace ducks.ducks
{
    public class ModelDuck: Duck
    {
        public ModelDuck(string name) : base(name, new FlyNoWay(), new MuteQuack())
        {
        }
    }
}