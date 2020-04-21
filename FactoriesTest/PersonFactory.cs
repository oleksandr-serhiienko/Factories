using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    public class PersonFactory
    {
        public Person CreatePerson(string name)
        {
            var person = new Person(Persons.Count, name);
            Persons.Add(person);
            return person;
        }

        private List<Person> Persons { get; set; } = new List<Person>();
    }
}
