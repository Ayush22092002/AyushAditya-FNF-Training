using Frameworks.DataComponents;
using Frameworks.Entities;
using Frameworks.Util;
using System;
using System.Configuration;
using System.IO;
namespace Frameworks.UIComponents
{
    internal class UCMainProgram
    {
        static string menu = File.ReadAllText(ConfigurationManager.AppSettings["menuFile"]);
        static IEmployeeManager EmployeeManager = EmployeeManagerFactory.CreateEmployeeManager();
        static void Main(string[] args)
        {
            bool processing = false;
            do
            {
                var choice = MyConsole.GetNumber(menu);
                processing = processMenu(choice);
                Console.Clear();
            } while (processing);            
        }

        //todo: U should create the features and call the appropriate apis. 
        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingFeature();
                    return true;
                case 3:
                case 2:
                case 4:
                case 5:
                case 6:
                    return true;
                default:
                    return false;
            }
        }

        private static void addingFeature()
        {
            //Take inputs from the User
            int id = MyConsole.GetNumber("Enter the Id");
            string name = MyConsole.GetString("Enter the Name");
            string address = MyConsole.GetString("Enter the Address");
            int salary = MyConsole.GetNumber("Enter the Salary");
            //Create the Employee object
            var emp = new Employee { EmpId = id, EmployeeAddress = address, EmployeeSalary = salary, EmpName = name };
            //Call the api to add the Employee
            EmployeeManager.AddEmployee(emp);
            MyConsole.PrintSuccessMessage("Employee Added successfully");
            Console.ReadKey();
        }
    }
}
