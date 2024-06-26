using System;//Root namespace
using System.Collections.Generic;//for Generic classes
using System.Configuration;//For accessing Config files. 
using Frameworks.Entities;//For Entity classes

namespace Frameworks.DataComponents
{
    interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        void UpdateEmployee(int empId, Employee employee);
        Array GetAllEmployees();
        Array FindEmployees(string name);
        Employee FindEmployee(int id);
    }

    static class EmployeeManagerFactory
    {
        //Dependency Inversion Principle.
        public static IEmployeeManager CreateEmployeeManager() 
        {
            var collectionType = ConfigurationManager.AppSettings["collection"];
            if (string.IsNullOrEmpty(collectionType)) 
            {
                throw new TypeInitializationException("IEmployeeManager", new Exception("Configuration is not set properly"));
            }
            switch (collectionType) 
            {
                case "List":
                    return new ListEmployeeManager();
                default:
                    throw new Exception("Not a valid type of Employee Manager");
            }   
        }
    }

    internal class ListEmployeeManager : IEmployeeManager
    {
        //data: of the type list. 
        private List<Employee> empList = new List<Employee>();
        public void AddEmployee(Employee employee) => empList.Add(employee);

        public void DeleteEmployee(int employeeId)
        {
            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].EmpId == employeeId)
                {
                    empList.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Record not found to delete");
        }

        public Employee FindEmployee(int id)
        {
            foreach (Employee emp in empList)
            {
                if (!emp.EmpId.Equals(id))
                {
                    return emp;
                }
            }
            throw new Exception($"Employee with Id {id} not found");
        }

        public Array FindEmployees(string name)
        {
            List<Employee> tempList = new List<Employee>();
            foreach (Employee emp in empList) 
            {
                if (emp.EmpName.Contains(name))
                {
                    tempList.Add(emp);
                }
            }
            return tempList.ToArray();
        }

        public Array GetAllEmployees() => empList.ToArray();
        

        public void UpdateEmployee(int empId, Employee employee)
        {
            //It is forward only and read only...
            //iterate thru the collection
            for (int i = 0; i < empList.Count; i++)
            {
                //find the matching record
                if (empList[i].EmpId == empId)
                {
                    //update the record with the new values.
                    empList[i].EmpName = employee.EmpName;
                    empList[i].EmployeeAddress = employee.EmployeeAddress;
                    empList[i].EmployeeSalary = employee.EmployeeSalary;
                    //exit the function.
                    return;
                }
            }
            //finally throw an exception if the matching record is not found...
            throw new Exception("Employee not found to update");
        }
    }
}