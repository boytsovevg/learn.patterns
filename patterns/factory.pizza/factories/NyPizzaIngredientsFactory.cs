using factory.pizza.ingridients;
using factory.pizza.ingridients.cheese;
using factory.pizza.ingridients.dough;
using factory.pizza.ingridients.sauce;
using factory.pizza.ingridients.seafood;

namespace factory.pizza.factories
{
    public class NyPizzaIngredientsFactory: IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ISeafood CreateSeafood()
        {
            return new FreshClams();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }
    }
}