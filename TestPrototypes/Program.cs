using System;

namespace TestPrototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "john", "Smith" }, new Adress("MyStreet", 447));;
            var jane = new Person(john.DeepCopy());
            jane.Adress.HouseNumber = 222;
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
