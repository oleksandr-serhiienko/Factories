using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoriesTest
{
    public class AsyncFactoryMethod
    {
        public AsyncFactoryMethod()
        {
            
        }

        public async Task<AsyncFactoryMethod> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
    }
}
