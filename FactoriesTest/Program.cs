using FactoriesTest.Drink;
using System;
using System.Threading.Tasks;

namespace FactoriesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);

            //var test = new AsyncFactoryMethod();
            //await test.InitAsync();

            //var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);

            //var x = await AsyncFactoryMethod.CreateAsync();

            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailbleDrink.Tea, 100);
            //drink.Consume();
            var drink = machine.MakeDrink();
            drink.Consume();

        }
    }
}
