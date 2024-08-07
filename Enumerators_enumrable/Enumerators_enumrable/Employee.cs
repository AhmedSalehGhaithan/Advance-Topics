using System.Collections.Generic;

namespace Enumerators_enumrable
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal salary { get; set; }
           
        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Employee)) return false;

            var emp = obj as Employee;   
            return this.Id ==emp.Id 
                && this.Name == emp.Name 
                && this.Department == emp.Department 
                && this.salary == emp.salary;
        }

        public static bool operator ==(Employee left, Employee right) =>left.Equals(right);
        public static bool operator !=(Employee left, Employee right) => !left.Equals(right);
    }
}
