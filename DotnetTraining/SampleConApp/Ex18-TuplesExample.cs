using System;
using System.Net.Cache;

/*
 * Tuples were introduced in C# 5.0
 * Tuples are a convinient way to store a set of values of different datatypes into a single object without a need to create a seperate class or a struct. It is typically used to return multiple values from a method without creating a custom class.
 * Create method is used to create a Tuple object. Elements created would be accessible in the form Item no. 
 * In C# 7.0, U could name the elements and refer them as properties. 
 * One of the main practical reasons for using Tuples is to return multiple values from a function instead of using ref or out parameters. 
 * To provide powerful and flexible way to group multiple values together without an overhead of defining custom types. They are also helpful when U want multiple values from a LINQ queries. It now replaces most of the Anonymous types that were created in C# 4.0 or earlier versions. 
 */
namespace SampleConApp
{

    internal class Ex18_TuplesExample
    {
        static (int sum, int product)Calculate(int v1, int v2)
        {
            return (v1 + v2, v1 * v2);
        }
        static void Main()
        {
            //Anonymous types. 
            var bill = new { Name = "Phaniraj", Address = "Bangalore", Salary = 56000 };

            //var emp = Tuple.Create("Phaniraj", 47, 9945205684);
            var emp = (Name: "Phaniraj", Age: 47, Mobileno: 9952343456); //From C# 7.0
            Console.WriteLine(emp);
            Console.WriteLine("The Name is " + emp.Name);
            Console.WriteLine("The age is " + emp.Age);
            Console.WriteLine("The contact no is " + emp.Mobileno);

            var (no1, no2) = Calculate(12, 3);
            Console.WriteLine($"The sum: {no1}, The product: {no2}");
        }
    }
}
