using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest.Drink
{
    public class HotDrinkMachine
    {
        //public enum AvailbleDrink
        //{
        //    Coffee, Tea, HotChocolate
        //}

        //private Dictionary<AvailbleDrink, IHotDrinkFactory> factories =
        //    new Dictionary<AvailbleDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvailbleDrink drink in Enum.GetValues(typeof(AvailbleDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance
        //            (
        //            Type.GetType("FactoriesTest.Drink." + Enum.GetName(typeof(AvailbleDrink), drink) + "Factory")
        //            );

        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvailbleDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}
        private List<(string, IHotDrinkFactory)> factories = new List<(string, IHotDrinkFactory)>();


        public HotDrinkMachine()
        {


            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add((t.Name.Replace("Factory", string.Empty), 
                                  (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drings");
            for (int i = 0; i < factories.Count; i++)
            {
                var t = factories[i];
                Console.WriteLine($"{i}: {t.Item1}");
                
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < factories.Count)
                {
                    Console.WriteLine("Specifie the amount");
                    s = Console.ReadLine();
                    if ((s != null
                            && int.TryParse(s, out int amount)
                            && amount >= 0))
                        {
                            return factories[i].Item2.Prepare(amount);
                        }
                }
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
