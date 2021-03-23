using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Employees.Domain.Models
{
    public class SpecialManager : INotifyPropertyChanged
    {
        public IList<LineWorker> Staff { get; set; }

        bool IsManager = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Salary { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public SpecialManager()
        {
            Staff = new List<LineWorker>();
            IsManager = true;
        }  

        public void AddStaff(LineWorker worker)
        {
            Staff.Add(worker);
            OnPropertyChanged();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}