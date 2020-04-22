using System;

namespace TestPrototypes
{
    [Serializable]
    public class Person 
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

    }
}
