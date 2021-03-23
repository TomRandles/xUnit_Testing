using System.Collections.Generic;

namespace Employees.Domain.Models
{
    public class Manager : Employee
    {
        public IList<LineWorker> Staff { get; set; }
        public Manager()
        {
            Staff = new List<LineWorker>();
            IsManager = true;
        }

        public double Salary { get; set; }

        public void AddStaff(LineWorker worker)
        {
            Staff.Add(worker);
        }
    }
}