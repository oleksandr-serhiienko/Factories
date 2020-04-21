using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest.Drink
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int Amount)
        {
            Console.WriteLine($"Put a coffee, cream, pour {Amount} water and add lemon");
            return new Coffee();
        }
    }
}
