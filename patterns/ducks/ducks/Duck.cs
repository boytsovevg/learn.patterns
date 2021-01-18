using ducks.bahavoir;

namespace ducks.ducks
{
    public class Duck
    {
        private readonly IFlyable _flyBehavior;
        private readonly IQuackable _quackBehavior;
        private string Name { get; }

        public Duck(string name, IFlyable flyBehavior, IQuackable quackBehavior)
        {
            this.Name = name;
            this._flyBehavior = flyBehavior;
            this._quackBehavior = quackBehavior;
        }

        public string Display()
        {
            return $"I am {this.Name}";
        }

        public void Fly()
        {
            this._flyBehavior.FlyAction();
        }

        public void Quack()
        {
            this._quackBehavior.QuackAction();
        }
    }
}