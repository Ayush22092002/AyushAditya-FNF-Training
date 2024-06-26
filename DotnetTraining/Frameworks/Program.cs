using Frameworks.Entities;
using Frameworks.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*
 * As Arrays have limitations, we use Collection classes that have predefined infrastructure to store the data in certain formats. 
 * List<T>, Dictionary<K, V>, HashSet<K>, Queue<T> and Stack<T>.
 * There is a non generic version of Collections that was available since .NET 1.0(2002). Generic Collections came in .NET 2.0.(2005)
 * Collections are a group of classes that help is storing data in predefined structures that suit UR business requirement. 
 * NonGeneric collections store the data as boxed data(objects). U might need to Unbox them(overhead) for performing any computations.
 * With Generics, we can create objects as a template. Similar to C++ Templates. 
 * Important Generice classes:
 * List<T>
 * HashSet<T>
 * Dictionary<K,V>
 * Queue<T>
 * Stack<T>
 * SortedDictionary<T>
 * What is an HashCode? In new Programming languages like Java and C#, every object that is created in the System is identified by a unique value called HashCode. When objects have the same HashCode, it means that they belong to the same type. Then, if the objects are equal(Equals method) then the object equivalence will come into picture. 
*/
namespace Frameworks
{
    internal class GenericCollections
    {
        static Dictionary<string, string> loginUsers = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            //DictionaryExample();
            //HashSetExample();
            //listExample();
            //GenericCollectionEample();
            //NonGenericCollectionsExample();
            //QueueExample();
            //StackExample();
            //SortedListExample();
        }

        private static void SortedListExample()
        {
            //Sorted List allows to store the data in a sorted manner based on the key. Here the data is stored as key-value pairs. It is faster way of retrieving the data compared to SortedDictionary.
            //SortedList is more optimized compared to SortedDictionay. SortedList also used less memory compared to SortedDictionary. 
            //However, SortedDictionary has faster insertions and removal operations for unsorted data. 

            SortedList<int, Employee> empList = new SortedList<int, Employee>();
            empList[1] = new Employee { EmpName = "Raj", EmpId = 111, EmployeeAddress = "BLR", EmployeeSalary = 5000 };
            empList[3] = new Employee { EmpName = "Ram", EmpId = 112, EmployeeAddress = "HSN", EmployeeSalary = 5000 };
            empList[5] = new Employee { EmpName = "Tom", EmpId = 113, EmployeeAddress = "HPT", EmployeeSalary = 5000 };
            empList[2] = new Employee { EmpName = "Tim", EmpId = 114, EmployeeAddress = "MDY", EmployeeSalary = 5000 };
            empList[7] = new Employee { EmpName = "Khan", EmpId = 115, EmployeeAddress = "MYS", EmployeeSalary = 5000 };
            empList[6] = new Employee { EmpName = "Rohit", EmpId = 116, EmployeeAddress = "BLR", EmployeeSalary = 5000 };

            foreach (var pair in empList) {
                Console.WriteLine($"EmpNo: {pair.Key}, EmpName: {pair.Value.EmpName}");
            }
        }

        private static void StackExample()
        {
            //Items are added one above the other. The Last item added will be the first item to be removed. 
            //Solitaire game works like a Stack. 
            Stack<string> stackofBooks = new Stack<string>();
            stackofBooks.Push("3 Idiots");
            stackofBooks.Push("The WallStreet Hacker");
            stackofBooks.Push("The God Father");
            stackofBooks.Push("The Don");
            stackofBooks.Push("The Code Complete");
            foreach (var book in stackofBooks) 
            {
                Console.WriteLine(book);
            }
            var removedBook = stackofBooks.Pop();//Take the top most item and returns it. 
            Console.WriteLine("The book that is removed: " + removedBook);
        }

        private static void QueueExample()
        {
            //Works as First in First Out basis, elements will be added to the bottom of the Queue, first element added will the element that can be removed in the queue. U cannot insert/remove intermediate items in the queue. 
            Queue<string> viewedList = new Queue<string>();
            do
            {
                string item = MyConsole.GetString("Enter the Item to view");
                if(viewedList.Count == 5)
                {
                    viewedList.Dequeue();//Removes the first item from the Queue
                }
                viewedList.Enqueue(item);//Adds the item to the bottom of the Queue
                var recentList = viewedList.ToList();
                recentList.Reverse();
                foreach(var pr in recentList)
                    Console.WriteLine(pr);
            } while (true);
        }

        private static void DictionaryExample()
        {
            //Key - Value pairs. It will not be sorted. In the collection, the key is unique and follows the HashCode to get its uniqueness. Value might not be unique.
            //Username, Password.
            //simpleExampleOnDictionary();
            passwordValidationExample();
        }

        private static void passwordValidationExample()
        {
            do
            {
                Console.WriteLine("Press 1 to Login or 2 to Register");
                int choice = int.Parse(Console.ReadLine());
                var username = MyConsole.GetString("Enter the Login Id");
                var pwd = MyConsole.GetString("Enter UR Password");
                if (choice == 1)
                {
                    SignIn(username, pwd);
                }
                else if (choice == 2)
                {
                    SignUp(username, pwd);
                }
            } while (true);
        }

        public static void SignIn(string username, string password)
        {
            if (!loginUsers.ContainsKey(username))
            {
                Console.WriteLine("User does not exist");
            }
            else
            {
                if (loginUsers[username] == password)
                {
                    Console.WriteLine("Login Sucessfull");
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }
        }
        public static void SignUp(string username, string password)
        {
            //first check for the username.
            if (loginUsers.ContainsKey(username))
            {
                //if found, return saying the user is already registered...
                Console.WriteLine("User is already registered, Please check to reissue the new Password from our Admin");
            }
            else
            {
                //not found, then add the user with pwd and display the success message
                loginUsers[username] = password;
                Console.WriteLine("User is successfully registered, please login to go further");
            }
        }
        private static void simpleExampleOnDictionary()
        {
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(111, "Phaniraj");//One way to add.
            users[112] = "Karthik";//If the key is already present, it shall update the value, else it will add with new key and value pair. 
            if (users.ContainsKey(112))
            {
                Console.WriteLine("User already Exists");
            }
            else
            {
                users[112] = "Suresh";
            }
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Key}\t Name: {user.Value}");
            }
        }

        private static void HashSetExample()
        {
            //HashSet is very similar to List, but will store only unique data. No duplicates.
            //HashSetWithValueTypes();
            HashSet<Employee> employees = new HashSet<Employee>();
            //How adding happens in HashSet for reference types:First it checks the HashCode of the object with all the existing elements, if they differ, then the object is added to the collection. If the Hashcode is same, then it goes to the Equals method to check the logical equivalence of the objects and if true, will not add, else it shall add to the collection. 

            employees.Add(new Employee { EmpId = 11, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Suresh" });
            employees.Add(new Employee { EmpId = 12, EmployeeAddress = "Mysore", EmployeeSalary = 50000, EmpName = "Ramesh" });
            employees.Add(new Employee { EmpId = 13, EmployeeAddress = "Hassan", EmployeeSalary = 50000, EmpName = "Mahesh" });
            employees.Add(new Employee { EmpId = 14, EmployeeAddress = "Tumkur", EmployeeSalary = 50000, EmpName = "Rajesh" });
            employees.Add(new Employee { EmpId = 15, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Pinto" });
            employees.Add(new Employee { EmpId = 15, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Pinto" });
            employees.Add(new Employee { EmpId = 15, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Pinto" });

            Console.WriteLine("The Current Emp List: " + employees.Count);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmpName} from {employee.EmployeeAddress}");
            }
        }

        private static void HashSetWithValueTypes()
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            if (!list.Add(2))
                Console.WriteLine("The list already has 2");
            if (!list.Add(3))
                Console.WriteLine("The list already has 3");
            Console.WriteLine("The count: " + list.Count);
        }

        //list is very similar to arrays but dynamic in nature. elements are added to the bottom of the list. U can add/remove/update elements at any point in this collection. Performancewise it is slow as it dynamically changes the memory as and when modify it. It does not check for duplicates. Very convinient way to store elements with no overheads. 
        private static void listExample()
        {
            //Add, Remove. InsertAt, Count
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmpId = 11, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Suresh" });
            employees.Add(new Employee { EmpId = 12, EmployeeAddress = "Mysore", EmployeeSalary = 50000, EmpName = "Ramesh" });
            employees.Add(new Employee { EmpId = 13, EmployeeAddress = "Hassan", EmployeeSalary = 50000, EmpName = "Mahesh" });
            employees.Add(new Employee { EmpId = 14, EmployeeAddress = "Tumkur", EmployeeSalary = 50000, EmpName = "Rajesh" });
            employees.Add(new Employee { EmpId = 15, EmployeeAddress = "Bangalore", EmployeeSalary = 50000, EmpName = "Pinto" });
            employees.Insert(3, new Employee { EmpId = 16, EmployeeAddress = "Mandya", EmployeeSalary = 60000, EmpName = "Sumanth" });

            Console.WriteLine("The Current Emp List: " + employees.Count);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmpName} from {employee.EmployeeAddress}");
            }
        }

        private static void GenericCollectionEample()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Mangoes");
            fruits.Add("Apples");
            fruits.Add("Pine Apples");
            //fruits.Add(2342343);//U cannot add other kinds of data into the collection. 
            foreach (string s in fruits)
            {
                Console.WriteLine(s.ToUpper());//No unboxing required.
            }
        }

        private static void NonGenericCollectionsExample()
        {
            ArrayList list = new ArrayList();
            list.Add("Apples");//Old collections box the value into the collection
            list.Add("Mangoes");
            list.Add("Oranges");
            list.Add("PineApples");
            list.Add(234.4566);
            list.Add("Custard Apples");
            Console.WriteLine("The no of elements in the collection : " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString().ToUpper());
            }
        }
    }
}
