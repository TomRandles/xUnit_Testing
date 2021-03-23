using System;

namespace Employees.Domain
{
    public abstract class Employee
    {
        public bool IsManager { get; set; } = false;
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }
    }
}
