using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//var is a keyword that is used as a local variable to store local values without a need to declare it with a specific data type. 
//They are also called as IMPLICITLY TYPED VARIABLES. 
//They automatically hold the data type of the value that is assigned to it.
//Once assigned, it follows the rules of a typical strongly typed variable. 
//Limitations: var can be used only as local variables. It cannot be used as return type, parameter of a function or even a field of a class. U cannot declare var without initialization
namespace SampleConApp
{
    internal class Ex19_VarKeywordUsage
    {
        static void Main(string[] args)
        {
            var name = "Sumanth";
            //name = 234;
            var cst = new Customer { Id = 123, Address = "Mysore", Name = "Ramesh", CustomerBill = 500 };
            Console.WriteLine("The Name: " + cst.Name); ;//There is no need for any boxing or unboxing. 
        }
    }
}
