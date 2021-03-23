using Employees.Domain.Factory;
using Employees.Domain.Models;
using System;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class EventsAssertTests
    {
        [Fact]
        public void RaisePropertyChangedEvent()
        {
            var sut = new SpecialManager();
            var lineWorker = new LineWorker();

            Assert.PropertyChanged(sut, "AddStaff", () => sut.AddStaff(lineWorker));
        }
    }
}