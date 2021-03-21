using System.Collections.Generic;

namespace HFDP.AbstractFactory.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public IEnumerable<Veggies> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}
