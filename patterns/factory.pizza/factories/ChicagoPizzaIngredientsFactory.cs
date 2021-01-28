using factory.pizza.ingridients;
using factory.pizza.ingridients.cheese;
using factory.pizza.ingridients.dough;
using factory.pizza.ingridients.sauce;
using factory.pizza.ingridients.seafood;

namespace factory.pizza.factories
{
    public class ChicagoPizzaIngredientsFactory: IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ISeafood CreateSeafood()
        {
            return new FrozenClams();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
    }
}