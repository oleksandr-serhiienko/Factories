using System;
using System.Threading.Tasks;

namespace FactoriesTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);

            //var test = new AsyncFactoryMethod();
            //await test.InitAsync();

            var x = await AsyncFactoryMethod.CreateAsync();

        }
    }
}
