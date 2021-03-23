using Employees.Domain.Exceptions;
using Employees.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain.Factory
{
    public class ManagerFactory
    {
        public Manager CreateManager (string firstName, string lastName, DateTime dob)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                throw new InvalidManagerException("Invalid name");
            var manager = new Manager { FirstName = firstName, LastName = lastName, DateOfBirth = dob };
            return manager;
        }

        public void Create(object p)
        {
            throw new NotImplementedException();
        }
    }
}
