using System;
using System.Configuration;

/*
 * An interface is an entity that contains only abstract methods in them. 
 * The methods of the interface are always public. 
 * The Class that implements an interface must implement all the methods of the interface. They can however redeclare the method as abstract and make itself an Abstract class. The access specifier for the implemented methods must be public.
 * The idea of the interface is to enforce a rule to implement all the methods like a contract, the contract is the interface and enforcing is done by the implementor classes. 
 * Interfaces are the basis for most of the Software frameworks that are available in the computer software industry.  
 * inter
 */
namespace SampleConApp
{
    interface IEmployeeManager
    {
         void AddEmployee(Employee employee);//(C)
        void RemoveEmployee(int empId);//D
        void UpdateEmployee(int empId, Employee employee);//U
        Array GetAllEmployees();//R        
    }

    class OracleDbEmployeeManager : IEmployeeManager
    {
        public void AddEmployee(Employee employee)
        {
            Console.WriteLine("Employee added to Oracle Server database");
        }

        public Array GetAllEmployees()
        {
            Console.WriteLine("All Employees are retrieved from Oracle Server database");
            return new Employee[0];
        }

        public void RemoveEmployee(int empId)
        {
            Console.WriteLine("Employee removed From Oracle Server database");
        }

        public void UpdateEmployee(int empId, Employee employee)
        {
            Console.WriteLine($"Employee with Id {empId} is updated to Oracle Server database");

        }
    }
    class SqlDBEmployeeManager : IEmployeeManager
    {
         public void AddEmployee(Employee employee)
        {
            Console.WriteLine("Employee added to Sql Server database");
        }

        public Array GetAllEmployees()
        {
            Console.WriteLine("All Employees are retrieved from Sql Server database");
            return new Employee[0];
        }

        public void RemoveEmployee(int empId)
        {
            Console.WriteLine("Employee removed From Sql Server database");
        }

        public void UpdateEmployee(int empId, Employee employee)
        {
            Console.WriteLine($"Employee with Id {empId} is updated to Sql Server database");

        }
    }

    class EmployeeFactory
    {
        public static IEmployeeManager CreateEmployeeManager()
        {
            string type = ConfigurationManager.AppSettings["DbType"];
            switch (type)
            {
                case "Sql": return new SqlDBEmployeeManager();
                case "Oracle": return new OracleDbEmployeeManager();
                default: throw new NotImplementedException();
            }
        }
    }
    internal class Ex12_InterfaceExample
    {
        static IEmployeeManager mgr;
        static void Main(string[] args)
        {
            mgr = EmployeeFactory.CreateEmployeeManager();
            mgr.AddEmployee(new Employee());
            mgr.AddEmployee(new Employee());
            mgr.AddEmployee(new Employee());
            mgr.AddEmployee(new Employee());
            Console.ReadKey();  
        }
    }
}
//Todo: Create a Menu Driven Program that allows the User to select an option of the prefered Crud Operation and appropriately performs that action. It should be a continueous running app which closes only on request. It should not terminate abruptly. 
