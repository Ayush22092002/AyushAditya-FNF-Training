using SampleConApp.Util;
using System;
/*
 * A Class is User defined Reference type. 
 * It comes with OOP features like Inheritance, Polymorphism, Encapsulation, Abstraction. 
 * It can contains data as well as functions to manipulate the data. 
 * Usually the data is hidden.(Accessible only within the class). 
 * We can use Functions or Properties(Getters/Setters) to access the private data. 
 * Classes are created to have composite data types and functions to perform real time operations.
 * Since C# 4.0, we have automatic properties which are public accessors to the hidden private fields. In this case, developers need not create private fields, it will be internally available for those properties. 
 * U can also have nested classes. Practically, we use nested classes if the class is intended to be used only within that class.
 * A class in C# will usually have fields(hidden data), methods(Functions to manipulate the data), Properties(Accessors to the data) and Events(Actions on the object). 
 * Events are created using a concept called DELEGATES. 
 * Members of a class can be instance based(Accessible only thru objects) or non instance based(Accessible by the Name of the class).
 * As C# does not support global functions, we can compensate it using static members as there will no instance specific operations, it shall be common to all. Instance based members are scoped to the object thru which they are working with.
 */

namespace SampleConApp
{
    /// <summary>
    /// A Class created to explain the older syntax of Properties
    /// </summary>
    class Employee_oldv
    {
        private int id;
        private string name;
        private int salary;
        private string designation;

        public int EmployeeId
        {
            get { return id; }
            set { id = value; }
        }

        public string EmployeeName 
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeSalary
        {
            get { return salary; }
            set { salary = value; }
        }
    }

    /// <summary>
    /// A Class explaining the new Automatic Properties.
    /// Here The class will have hidden backing fields for every public property U create. Use Ildasm tool to see the hidden fields from the Assembly Manifest. 
    /// </summary>
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }

    }

    /// <summary>
    /// A practical approach of creating a Class that represents a real time billing System. It has methods, read only properties as well as private fields to enable Encapsulation and Abstraction. 
    /// </summary>
    class CustomerBill
    {
        private const int size = 6;
        private int[] productDetails = new int[size];

        public DateTime BillDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }

        public void AddProductDetail(int amount)
        {
            for (int i = 0; i < size; i++)
            {
                if(productDetails[i] == 0)
                {
                    productDetails[i] = amount;
                    MyConsole.PrintSuccessMessage("Product Detail is added successfully");
                    return;
                }else continue;
            }
            MyConsole.PrintErrorMessage("No more products can be added!");
        }

        public int FinalBillAmount
        {
            get
            {
                int final = 0;
                foreach (int value in productDetails) 
                {
                    final += value;
                }
                return final;
            }
        }
    }
    internal class Ex06_ClassesDemo
    {
        static void Main(string[] args)
        {
            //int id = 123;
            //string name = "Phaniraj";
            //string designation = "Trainer";
            //int salary = 45000;

            //Employee employee = new Employee();
            //employee.Id = id;
            //employee.Name = name;
            //employee.Designation = designation;
            //employee.Salary = salary;
            
            //Employee_oldv empOld  = new Employee_oldv();
            //empOld.EmployeeId = 234;

            /////////////Testing the Properties and Methods/////////
            CustomerBill customerBill = new CustomerBill(); 
            customerBill.CustomerId = 1; //Setting the Id. 
            customerBill.AddProductDetail(346);
            customerBill.AddProductDetail(146);
            customerBill.AddProductDetail(346);
            customerBill.AddProductDetail(346);
            customerBill.AddProductDetail(346);
            customerBill.AddProductDetail(300);
            customerBill.AddProductDetail(300);
            //Try to set the Final Billing Amount and See what happens!
            MyConsole.PrintSuccessMessage($"The Bill Date:  {customerBill.BillDate.ToLongDateString()}");
            MyConsole.PrintSuccessMessage($"The final Bill is {customerBill.FinalBillAmount}");
            ///////////////////////////////////////////////////
        }
    }
}
