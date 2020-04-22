using System;

namespace TestPrototypes
{
    public class Person : ICloneable
    {
        public string[] Names;

        public Adress Adress;

        public Person(string[] names, Adress adress)
        {
            Names = names;
            Adress = adress;
        }

        public object Clone()
        {
            return new Person(Names, Adress);
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(" ", Names)}, {nameof(Adress)}: {Adress}";
        }
    }
}
