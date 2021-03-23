using Employees.Domain.Models;
using System;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class StringAssertTests
    {
        [Fact]
        [Trait("Employee", "String")]
        public void CalculateFullName()
        {
            var sut = new Manager();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            Assert.Equal("Sarah O'Sullivan", sut.FullName);
        }

        [Fact]
        [Trait("Employee", "String")]
        public void HaveFullNameStartingWithFirstName()
        {
            var sut = new Manager();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            Assert.StartsWith("Sarah", sut.FullName);
        }

        [Fact]
        [Trait("Employee", "String")]
        public void HaveFullNameEndingWithLastName()
        {
            var sut = new LineWorker();

            sut.LastName = "Smith";

            Assert.EndsWith("Smith", sut.FullName);
        }

        [Fact]
        [Trait("Employee", "String")]
        public void CalculateFullName_IgnoreCaseAssertExample()
        {
            var sut = new Manager();

            sut.FirstName = "SARAH";
            sut.LastName = "MURPHY";

            Assert.Equal("Sarah Murphy", sut.FullName, ignoreCase: true);
        }

        [Fact]
        [Trait("Employee", "String")]
        public void CalculateFullName_SubstringAssertExample()
        {
            var sut = new LineWorker();

            sut.FirstName = "John";
            sut.LastName = "McEnery";

            Assert.Contains("hn Mc", sut.FullName);
        }


        [Fact]
        [Trait("Employee", "String")]
        public void CalculateFullNameWithTitleCase()
        {
            var sut = new LineWorker();

            sut.FirstName = "Jonah";
            sut.LastName = "Smith";

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.FullName);
        }
    }
}
