using System;

namespace ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            
            Console.WriteLine(duck.Display());
        }
    }
}