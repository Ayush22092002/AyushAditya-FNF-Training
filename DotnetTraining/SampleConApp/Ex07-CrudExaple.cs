using System;
using System.Diagnostics;
using System.IO;
using SampleConApp.Util;
using System.Linq;
using System.Configuration;
//SOLID Priciples. 
/*
 * Todo: Create a Customer management software that stores the customer info of the Shopping Market. It stores the Customer info, allows to search for the Customer by name or by Id. Delete operation is optional. 
 * When U design a class, it must serve only one purpose. This is called as "SEPERATION OF CONCERNS"
 */
namespace SampleConApp
{
    /// <summary>
    /// Represents a real world Customer.
    /// </summary>
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CustomerBill { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\tAddress: {Address}\tBill: {CustomerBill:C}";
        }

        //Used to implement logical equivalance for an object. 
        public override bool Equals(object obj)
        {
           Customer unboxed = obj as Customer;
            if ((this.Id == unboxed.Id) && (this.Name == unboxed.Name))
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// Represents the operations related to the Customer software. 
    /// </summary>
    class CustomerManager
    {
        //AddCustomer, SearchByName, SearchById, UpdateCustomer. 
        #region Private members
        private Customer[] customers = new Customer[100];
        #endregion

        #region Operations
        public void AddNewCustomer(Customer customer)
        {
            //Run thru the collection, find the first occurance of null in any location and set the new Customer details at that location. 
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == null)
                {
                    customers[i] = new Customer
                    {
                        Id = i + 1,
                        Name = customer.Name,
                        Address = customer.Address,
                        CustomerBill = customer.CustomerBill
                    };
                    return;
                }
            }
            //Raise an exception if no location is found for the new Customer. 
        }
        public void UpdateCustomer(Customer customer) 
        {
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] != null && customers[i].Id == customer.Id)
                {
                    customers[i].Name = customer.Name;
                    customers[i].Address = customer.Address;
                    return;
                }
            }
            //Raise an Exception if no Customer is found to update...
        }

        public Customer[] SearchCustomer(string name)
        {
            //need to filter only those customers with matching name. 
            return customers.Where((cst) => cst != null && cst.Name.StartsWith(name)).ToArray();
        }
        public Customer SearchCustomer(int id) 
        {
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] != null && customers[i].Id == id)
                {
                    return customers[i];
                }
            }
            return null;   //If the customer is not found... 
        }
        #endregion
    }

    class UIMainProgram
    {
        static string shopName = ConfigurationManager.AppSettings["shopName"];
        static string fileName = ConfigurationManager.AppSettings["menuFile"];
        static CustomerManager manager = new CustomerManager();

        static void Main(string[] args)
        {
            string menu = File.ReadAllText(fileName);
            Console.WriteLine($"Welcome to the {shopName}");
            bool processing = false;
            do
            {
                string choice = MyConsole.GetString(menu);
                processing = ProcessMenu(choice);
            } while (processing);
        }

        //break, return, continue, throw
        private static bool ProcessMenu(string choice)
        {
            switch (choice)
            {
                case "N":
                    addingCustomerFeature();
                    return true;
                case "F":
                    findingCustomerByNameFeature();
                    return true;
                case "I":
                    findingCustomerByIdFeature();
                    return true;
                case "U":
                    updatingCustomerFeature();
                    return true;
                default:
                    return false;
            }
        }
        private static void updatingCustomerFeature()
        {
            int id = MyConsole.GetNumber("Enter the Id of the Customer to update");
            string name = MyConsole.GetString("Enter the Customer Name to Update");
            string address = MyConsole.GetString("Enter the New Address");
            Customer cst = new Customer
            {
                Id = id,
                Address = address,
                Name = name
            };

            //Use the object and call the method. 
            manager.UpdateCustomer(cst);
            MyConsole.PrintSuccessMessage("Customer details are added successfully");
        }

        private static void findingCustomerByIdFeature()
        {
            int id = MyConsole.GetNumber("Enter the id of the Customer to search");
            Customer cst = manager.SearchCustomer(id);
            if(cst != null)
            {
                MyConsole.PrintSuccessMessage("Customer details are available!!");
                Console.WriteLine("The Name is: " + cst.Name);
                Console.WriteLine("The Address is: " + cst.Address);
                Console.WriteLine("The Last Bill Amount was: " + cst.CustomerBill);
            }
            else
            {
                MyConsole.PrintErrorMessage("No customer found for the given Id");
            }
        }

        private static void findingCustomerByNameFeature()
        {
            string name = MyConsole.GetString("Enter the Name or partial name of the Customer to search");
            Array list = manager.SearchCustomer(name);
            foreach(Customer cst in list)
            {
                Console.WriteLine(cst.Name);
            }
        }


        private static void addingCustomerFeature()
        {
            string name = MyConsole.GetString("Enter the Customer Name");
            string address = MyConsole.GetString("Enter the Address");
            int bill = MyConsole.GetNumber("Enter the Bill Amount");
            Customer cst = new Customer
            {
                Address = address,
                Name = name,
                CustomerBill = bill
            };

            //Use the object and call the method. 
            manager.AddNewCustomer( cst );
            MyConsole.PrintSuccessMessage("Customer details are added successfully");
        }
    }
}
