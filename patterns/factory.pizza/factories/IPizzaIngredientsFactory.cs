using factory.pizza.ingridients;

namespace factory.pizza.factories
{
    public interface IPizzaIngredientsFactory
    {
        public IDough CreateDough();

        public ISauce CreateSauce();

        public ISeafood CreateSeafood();

        public ICheese CreateCheese();
    }
}