using System;

namespace TestPrototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "john", "Smith" }, new Adress("MyStreet", 447));
            var jane = john;
            jane.Names[0] = "Jane";
            Console.WriteLine(john);
            Console.WriteLine(jane);

        }
    }
}
