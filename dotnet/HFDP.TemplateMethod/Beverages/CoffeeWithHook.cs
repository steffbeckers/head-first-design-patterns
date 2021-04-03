using System;

namespace HFDP.TemplateMethod.Beverages
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like to add Sugar and Milk with your coffee? (y/n)");

            string answer = Console.ReadLine();
            return answer.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
