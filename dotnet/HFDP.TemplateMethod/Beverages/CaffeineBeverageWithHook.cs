using System;

namespace HFDP.TemplateMethod.Beverages
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourIntoCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
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

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
