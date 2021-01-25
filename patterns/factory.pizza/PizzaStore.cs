using factory.pizza.pizza;

namespace factory.pizza
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this._factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            var pizza = this._factory.CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }
    }
}