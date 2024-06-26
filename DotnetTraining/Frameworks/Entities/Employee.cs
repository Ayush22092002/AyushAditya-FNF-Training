using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Represent the data.
namespace Frameworks.Entities
{
    /// <summary>
    /// Represents the real world Employee for the Application.
    /// </summary>
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmployeeSalary { get; set; }
        public string EmployeeAddress { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee temp = obj as Employee;
                return ((temp.EmpId == this.EmpId) && (temp.EmpName == this.EmpName));
            }
            else
            {
                //They are not equal
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.EmpId;
        }
    }
}
