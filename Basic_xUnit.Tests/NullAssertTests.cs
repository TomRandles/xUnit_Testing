using Employees.Domain.Models;
using System;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class NullAssertTests
    {
        [Fact]
        [Trait("Employee", "Null")]
        public void FullNameNotSet()
        {
            var sut = new Manager();

            Assert.Null(sut.FirstName);
        }

        [Fact]
        [Trait("Employee", "Null")]
        public void FullNameSet()
        {
            var sut = new Manager();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            Assert.NotNull(sut.FullName);
        }
    }
}
