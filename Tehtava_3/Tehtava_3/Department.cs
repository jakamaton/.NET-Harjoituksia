using System;
using System.Collections.Generic;

namespace Tehtava_3
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public int EmployeeCount { get { return Employees.Count; } }

        

        public Department()
        {
            Employees = new List<Employee>();
        }

        public Department(int id, string name)
            :this()
        { 
            this.Id = id;
            this.Name = name;
        }

        public override string ToString() { 
            return $"{Name} {EmployeeCount}";
        }
    }
}
