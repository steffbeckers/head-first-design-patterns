﻿using HFDP.AbstractFactory.Ingredients;
using System;

namespace HFDP.AbstractFactory.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
