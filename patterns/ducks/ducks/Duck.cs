using System;
using ducks.bahavoir;

namespace ducks.ducks
{
    public class Duck
    {
        private IFlyable _flyBehavior;
        private IQuackable _quackBehavior;
        private string Name { get; }

        public Duck(string name, IFlyable flyBehavior, IQuackable quackBehavior)
        {
            this.Name = name;
            this._flyBehavior = flyBehavior;
            this._quackBehavior = quackBehavior;
            
            this.Display();
        }

        public void SetFlyBehavior(IFlyable behavior)
        {
            this._flyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackable behavior)
        {
            this._quackBehavior = behavior;
        }

        public void Display()
        {
            Console.WriteLine($"I am {this.Name}");
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