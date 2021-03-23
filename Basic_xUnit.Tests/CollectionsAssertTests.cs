using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class CollectionsAssertTests
    {
        [Fact]
        public void CheckManagerStaffTest()
        {
            var expectedStaff = new LineWorker[]
            {
                new LineWorker {FirstName = "Jane", LastName = "O'Hara"},
                new LineWorker {FirstName = "Jack", LastName = "O'Hara"},
                new LineWorker {FirstName = "John", LastName = "O'Hara"}
            };
            var sut = new Manager();
            foreach (var employee in expectedStaff)
            {
                sut.AddStaff(employee);
            }

            Assert.Equal(expectedStaff, sut.Staff);
        }

        [Fact]
        public void CheckManagerStaffIsEmptyTest()
        {
            var sut = new Manager();

            Assert.Empty(sut.Staff);
        }

        [Fact]
        public void CheckManagerStaffIsNotEmptyTest()
        {
            var sut = new Manager();
            sut.AddStaff(new LineWorker());

            Assert.NotEmpty(sut.Staff);
        }

        [Fact]
        public void CheckManagerContainsStaffTest()
        {
            var expectedStaff = new LineWorker[]
            {
                new LineWorker {FirstName = "Jane", LastName = "O'Hara"},
                new LineWorker {FirstName = "Jack", LastName = "O'Hara"},
                new LineWorker {FirstName = "John", LastName = "O'Hara"}
            };
            var sut = new Manager();
            foreach (var employee in expectedStaff)
            {
                sut.AddStaff(employee);
            }

            Assert.Contains(sut.Staff, lineWorker => lineWorker.FirstName.Contains("Jack"));

            // Check list size
            Assert.Equal(expectedStaff.Length, sut.Staff.Count);
        }
    }
}