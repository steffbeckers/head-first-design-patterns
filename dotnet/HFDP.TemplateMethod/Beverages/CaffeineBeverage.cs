using System;

namespace HFDP.TemplateMethod.Beverages
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourIntoCup();
            AddCondiments();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
