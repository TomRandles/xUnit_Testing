using Employees.Domain;
using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class CollectionsAssertTests
    {
        private LineWorker[] expectedStaff = new LineWorker[]
        {
                new LineWorker {FirstName = "Jane", LastName = "O'Hara"},
                new LineWorker {FirstName = "Jack", LastName = "O'Hara"},
                new LineWorker {FirstName = "John", LastName = "O'Hara"}
        };

        private Manager _sut;

        public CollectionsAssertTests()
        {
            _sut = new Manager();
            foreach (var employee in expectedStaff)
            {
                _sut.AddStaff(employee);
            }
        }

        [Fact]
        [Trait("Manager", "Collection")]
        public void CheckManagerStaffTest()
        {
            Assert.Equal(expectedStaff, _sut.Staff);
        }

        [Fact]
        [Trait("Manager", "Collection")]
        public void CheckManagerStaffIsEmptyTest()
        {
            var sut2 = new Manager();

            Assert.Empty(sut2.Staff);
        }

        [Fact]
        [Trait("Manager", "Collection")]
        public void CheckManagerStaffIsNotEmptyTest()
        {
            Assert.NotEmpty(_sut.Staff);
        }

        [Fact]
        [Trait("Manager", "Collection")]
        public void CheckManagerContainsStaffTest()
        {
            Assert.Contains(_sut.Staff, lineWorker => lineWorker.FirstName.Contains("Jack"));

            // Check list size
            Assert.Equal(expectedStaff.Length, _sut.Staff.Count);
        }
    }
}