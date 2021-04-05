using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDP.Composite.Menus
{
    public class Menu : MenuComponent
    {
        public readonly string Name;
        public readonly string Description;
        public readonly List<MenuComponent> MenuComponents;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            MenuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return MenuComponents[index];
        }

        public override void Print()
        {
            Console.Write($"\n{Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine($"-------------------");

            IEnumerable<MenuComponent> menuComponents = MenuComponents.AsEnumerable();
            for (int i = 0; i < menuComponents.Count(); i++)
            {
                MenuComponent menuComponent = menuComponents.ElementAt(i);
                menuComponent.Print();
            }
        }
    }
}
