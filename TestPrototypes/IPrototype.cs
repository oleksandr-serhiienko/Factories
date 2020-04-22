using System;
using System.Collections.Generic;
using System.Text;

namespace TestPrototypes
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
