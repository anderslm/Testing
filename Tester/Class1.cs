using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Tester
{
    public class SuperClass<T>
    {

    }

    public class Class1 : SuperClass<Testing.Class1>
    {
        [Fact]
        public async Task Test()
        {
            var test = new Testing.Class1();
            await test.SomeAsync();
        }
    }
}
