﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoriesTest
{
    public class Person
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public Person( int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
