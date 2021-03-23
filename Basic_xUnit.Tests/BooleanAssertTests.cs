using Employees.Domain.Models;
using System;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class BooleanAssertTests
    {
        [Fact]
        [Trait("Manager", "Boolean")]
        public void IsManagerTest()
        {
            var empl = new Manager();

            Assert.True(empl.IsManager);
        }

        [Fact]
        [Trait("Manager", "Boolean")]
        public void IsNotManagerTest()
        {
            var empl = new LineWorker();

            Assert.False(empl.IsManager);
        }
    }
}