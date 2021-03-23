using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class EventsAssertTests
    {
        [Fact]
        [Trait("Manager", "Event")]
        public void RaisePropertyChangedEvent()
        {
            var sut = new SpecialManager();
            var lineWorker = new LineWorker();

            Assert.PropertyChanged(sut, "AddStaff", () => sut.AddStaff(lineWorker));
        }
    }
}