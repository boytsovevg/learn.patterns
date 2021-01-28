using factory.pizza.pizza;

namespace factory.pizza.factories
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                {
                    return new CheesePizza();
                }
                case "Pepperoni":
                {
                    return new PepperoniPizza();
                }
                case "Veggie":
                {
                    return new VeggiePizza();
                }
                default: return null;
            }
        }
    }
}