using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCollection
{
    class Employee
    {
        public string Name { get; set; }
        public bool? IsManager { get; set; }
        public double? Salary { get; set; }
    }
    internal class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList() 
        {
            Add(new Employee() { Name = "Jan Kowalski", IsManager = true, Salary = 123450.67 });
            Add(new Employee() {Name = "Janina Kowalski", IsManager = false, Salary = 1234.67 ,});
            Add(new Employee() { Name = "Mariusz Nowak" });
            Add(new Employee() { Name = "Maria Nowak", IsManager=false, Salary = 12345.67 });
        }
    }
}
