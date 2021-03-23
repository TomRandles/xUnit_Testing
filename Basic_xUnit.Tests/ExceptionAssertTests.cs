using Employees.Domain.Factory;
using Employees.Domain.Models;
using System;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class ExceptionAssertTests
    {
        [Fact]
        public void CheckManagerCreationExceptionTest()
        {
            var dateOfBirth = DateTime.Now.AddYears(-40);

            var sut = new ManagerFactory();

            Assert.Throws<InvalidManagerException>(() => sut.CreateManager("Jack", "", dateOfBirth));
        }
    }
}