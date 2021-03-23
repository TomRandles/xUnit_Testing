using Employees.Domain.Models;
using System;
using Xunit;

namespace BooleanAsserts.Test
{
    public class ManagerStatusTests
    {
        [Fact]
        public void IsManagerTest()
        {
            var empl = new Manager();

            Assert.True(empl.IsManager);
        }

        [Fact]
        public void IsNotManagerTest()
        {
            var empl = new LineWorker();

            Assert.False(empl.IsManager);
        }
    }
}