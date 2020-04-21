using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest.Drink
{
    public class HotDrinkMachine
    {
        public enum AvailbleDrink
        {
            Coffee, Tea
        }

        private Dictionary<AvailbleDrink, IHotDrinkFactory> factories =
            new Dictionary<AvailbleDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailbleDrink drink in Enum.GetValues(typeof(AvailbleDrink)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance
                    (
                    Type.GetType("FactoriesTest.Drink." + Enum.GetName(typeof(AvailbleDrink), drink) + "Factory")
                    );

                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailbleDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
