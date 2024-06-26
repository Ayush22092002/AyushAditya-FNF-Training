using System;
/*
 * .net has an universal data type called System.Object. It is the base class for all the .NET types. 
 * object is a reference type. 
 * Any data type value can be implicitly converted into object. However, the reverse operation is explicit. 
 * C# uses a term called BOXING for implicit Object conversion and UNBOXING for explicit type conversion from Object. 
 */

namespace SampleConApp
{
    internal class Ex14_ObjectClass
    {
        static void Main(string[] args)
        {
            //BoxingAndUnboxingExample();//This is called BOXING and the values are boxed into the object. 
            //ToStringImplementation();
            ObjectEquivalenceExample();
        }

        private static void ObjectEquivalenceExample()
        {
            Customer cst = new Customer { Address = "Mysore", Id = 123, CustomerBill = 4000, Name = "Sam" };

            Customer cstCopy = new Customer { Address = "Mysore", Id = 123, CustomerBill = 4000, Name = "Sam" };

            if(cst.Equals(cstCopy))
            {
                Console.WriteLine("They are same");
            }
            else
            {
                Console.WriteLine("They are not same");
            }
        }

        private static void ToStringImplementation()
        {
            Customer customer = new Customer();
            customer.Address = "Bangalore";
            customer.CustomerBill = 56000;
            customer.Name = "TestName";
            customer.Id = 123;
            //Internally, the WriteLine will evaluate the object into a string and displays it. 
            Console.WriteLine(customer);
        }

        private static void BoxingAndUnboxingExample()
        {
            object obj = 123;
            Console.WriteLine("The data type is " + obj.GetType().Name);
            int temp = (int)obj;
            temp += 123;
            obj = temp;
            Console.WriteLine("The value of the obj is " + obj);

            obj = 456.34;
            Console.WriteLine("The data type is " + obj.GetType().Name);

            obj = "Sample String";
            Console.WriteLine("The data type is " + obj.GetType().Name);
            string tempString = (string)obj;//UNBOXING. 
            obj = tempString.ToUpper();
            Console.WriteLine(obj);

        }
    }
}
