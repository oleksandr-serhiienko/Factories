using System;

namespace TestPrototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "john", "Smith" }, new Adress("MyStreet", 447));;
            var jane = john.DeepCopyXml();
            jane.Names[0] = "Jay";
            jane.Adress.HouseNumber = 222;
            Console.WriteLine(john);
            Console.WriteLine(jane);

            var line = new Line(new Point(2,2), new Point(3,1));
            var line1 = line.DeepCopy();
            line1.End.Y = 2;
            Console.WriteLine(line);
            Console.WriteLine(line1);
        }
    }
}
