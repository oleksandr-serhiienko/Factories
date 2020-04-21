using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest.Drink
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int Amount);
    }
}
