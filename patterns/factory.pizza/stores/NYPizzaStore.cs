using factory.pizza.factories;
using factory.pizza.pizza;

namespace factory.pizza.stores
{
    public class NyPizzaStore: PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public NyPizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        protected override IPizza CreatePizza(string type)
        {
            return this._factory.CreatePizza(type);
        }
    }
}