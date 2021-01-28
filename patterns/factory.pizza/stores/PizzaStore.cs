using factory.pizza.pizza;

namespace factory.pizza.stores
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            var pizza = this.CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            
            return pizza;
        }

        protected abstract IPizza CreatePizza(string type);
    }
}