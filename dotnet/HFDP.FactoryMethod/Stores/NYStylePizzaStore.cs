using HFDP.FactoryMethod.Pizzas;

namespace HFDP.FactoryMethod.Stores
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }

            return null;
        }
    }
}
