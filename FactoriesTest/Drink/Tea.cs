using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is ok");
        }
    }
}
