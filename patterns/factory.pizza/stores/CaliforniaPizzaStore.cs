using factory.pizza.pizza;

namespace factory.pizza.stores
{
    public class CaliforniaPizzaStore: PizzaStore
    {
        protected override IPizza CreatePizza(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}