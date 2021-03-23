using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class ObjectInstancesAssertTests
    {
        [Fact]
        [Trait("Employee", "Object Instances")]
        public void ManagerIsNotSameTest()
        {
            var sut = new Manager();
            var sut2 = new Manager();

            Assert.NotSame(sut, sut2);
        }

        [Fact]
        [Trait("Employee", "Object Instances")]
        public void ManagerIsSameTest()
        {
            var sut = new Manager();
            var sut2 = sut;

            Assert.Same(sut, sut2);
        }
    }
}