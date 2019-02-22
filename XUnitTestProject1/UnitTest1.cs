using System;
using Xunit;

namespace MyFirstUnitTests
{
    public class Class1
    {
        [Fact]
        public void TesteFuncionando()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }

}

