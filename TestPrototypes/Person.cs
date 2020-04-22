using System;

namespace TestPrototypes
{
    public class Person : IPrototype<Person>
    {
        public string[] Names;

        public Adress Adress;

        public Person(string[] names, Adress adress)
        {
            Names = names;
            Adress = adress;
        }

        public Person(Person other)
        {
            Names = other.Names;
            Adress = new Adress(other.Adress);
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(" ", Names)}, {nameof(Adress)}: {Adress}";
        }

        public Person DeepCopy()
        {
            return new Person(Names, Adress.DeepCopy());
        }
    }
}
