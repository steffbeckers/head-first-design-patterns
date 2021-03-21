using System.Collections.Generic;

namespace HFDP.AbstractFactory.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IEnumerable<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new BlackOlives(), new Spinach(), new Eggplant() };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }
    }
}
