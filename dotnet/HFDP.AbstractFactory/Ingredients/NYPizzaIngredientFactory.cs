using System.Collections.Generic;

namespace HFDP.AbstractFactory.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IEnumerable<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
}
