using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrototypes
{
    public class Person
    {
        public string[] Names;

        public Adress Adress;

        public Person(string[] names, Adress adress)
        {
            Names = names;
            Adress = adress;
        }

        public override string ToString()
        {
            return $"{nameof(Names)} : {string.Join(" ", Names)}, {nameof(Adress)}: {Adress}";
        }
    }
}
