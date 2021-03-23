using Employees.Domain;
using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class ObjectTypeAssertTests
    {
        [Fact]
        [Trait("Employee", "Object Type")]
        public void ManagerIsTypeTest()
        {
            var sut = new Manager();

            Assert.IsType<Manager>(sut);
        }

        [Fact]
        [Trait("Employee", "Object Type")]
        public void LineWorkerIsTypeTest()
        {
            var sut = new LineWorker();

            Assert.IsType<LineWorker>(sut);
        }

        [Fact]
        [Trait("Employee", "Object Type")]
        public void IsNotTypeTest()
        {
            var sut = new Manager();

            Assert.IsNotType<LineWorker>(sut);
        }

        [Fact]
        [Trait("Employee", "Object Type")]
        public void IsAssignableFromTest()
        {
            Employee sut = new Manager();

            Assert.IsAssignableFrom<Employee>(sut);
        }
    }
}