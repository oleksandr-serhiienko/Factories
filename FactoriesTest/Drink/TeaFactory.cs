using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest.Drink
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int Amount)
        {
            Console.WriteLine($"Put a tea, water, pour {Amount} water and add lemon");
            return new Tea();
        }
    }
}
