using MVCCoreApp.Models;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void PersonNameTest()
        {
            var expected = "Martyna xD";
            var person = new Person();
            person.Name = "Martyna";
            Assert.Equal(expected, person.Name);

        }
    }
}
