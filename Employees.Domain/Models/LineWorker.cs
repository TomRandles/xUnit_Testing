namespace Employees.Domain.Models
{
    public class LineWorker : Employee
    {
        public decimal PerHourRate { get; set; } = 12.0m;

        public decimal WeeklyHours { get; set; }

        public decimal WeeklyWage => PerHourRate * WeeklyHours;
        
        public LineWorker()
        {
            IsManager = false;
        }
    }
}