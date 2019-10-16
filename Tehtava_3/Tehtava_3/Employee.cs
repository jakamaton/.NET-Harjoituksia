using System;
namespace Tehtava_3
{
    public class Employee
    {
        public int Id { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Name { get { return $"{FirstName} {LastName}"; } }
        public int Age { get { if (DateOfBirth != null) { var ika = (TimeSpan)(DateTime.Now - DateOfBirth); return (ika.Days / 365); } else { return 0; } } }
        private double _salary;
        public double Salary { get { return Math.Round(_salary,2); } set { if (value < 0) { Salary = _salary; } else { throw new Exception("Palkka ei voi olla negatiivinen"); } } }

        public Employee(int id, string first, string last, DateTime? Dob, double salary)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            DateOfBirth = Dob;
            _salary = salary;
            StartDate = DateTime.Now;
            EndTime = null;
        }

        public override string ToString(){

            return $"{Id} {FirstName} {LastName}";
        }
        }
}
