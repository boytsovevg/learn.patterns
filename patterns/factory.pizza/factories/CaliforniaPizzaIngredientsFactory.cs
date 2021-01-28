using factory.pizza.ingridients;
using factory.pizza.ingridients.cheese;
using factory.pizza.ingridients.dough;
using factory.pizza.ingridients.sauce;
using factory.pizza.ingridients.seafood;

namespace factory.pizza.factories
{
    public class CaliforniaPizzaIngredientsFactory: IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new VeryThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new BruschettaSauce();
        }

        public ISeafood CreateSeafood()
        {
            return new Calamari();
        }

        public ICheese CreateCheese()
        {
            return new GoatCheese();
        }
    }
}