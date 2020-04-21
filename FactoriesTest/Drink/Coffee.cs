using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is mediocare");
        }
    }
}
