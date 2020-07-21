using System;
using Xunit;
using TestAPI.Controllers;

namespace TestAPI.Test
{
    public class UnitTest1
    {
        Values controller = new Values();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue  = controller.Get(1);
            Assert.Equal("Puneet Singh", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
