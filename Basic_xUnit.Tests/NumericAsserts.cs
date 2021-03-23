using Employees.Domain.Models;
using Xunit;

namespace Basic_xUnit.Tests
{
    public class NumericAsserts
    {

        [Fact]
        [Trait("Employee", "Numeric")]
        public void CheckHourlyRate()
        {
            var sut = new LineWorker();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            sut.PerHourRate = 15.5m;

            Assert.Equal(15.5m, sut.PerHourRate);
        }

        [Fact]
        [Trait("Employee", "Numeric")]
        public void CheckWeeklyHours()
        {
            var sut = new LineWorker();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            sut.PerHourRate = 15.5m;

            // Two decimal places
            Assert.Equal(15.5m, sut.PerHourRate, 2);
        }

        [Fact]
        [Trait("Employee", "Numeric")]
        public void CheckWageCalculation()
        {
            var sut = new LineWorker();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            sut.WeeklyHours = 38.5m;
            sut.PerHourRate = 15.5m;

            //two decimal places
            Assert.Equal((15.5m * 38.5m), sut.WeeklyWage, 2);
        }

        [Fact]
        [Trait("Employee", "Numeric")]
        public void CheckWageCalculationInRange()
        {
            var sut = new LineWorker();

            sut.FirstName = "Sarah";
            sut.LastName = "O'Sullivan";

            sut.WeeklyHours = 38.5m;
            sut.PerHourRate = 15.5m;

            Assert.InRange(sut.WeeklyWage, (decimal)(12 * 35), (decimal)(20.0 * 40.0));
        }
    }
}