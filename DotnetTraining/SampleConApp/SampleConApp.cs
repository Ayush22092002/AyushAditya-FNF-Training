using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Main is the entry point of the Project. It is case sensitive. 
 * Main should either return void or int. 
 * It can have optional args of the type string Array. 
 * Main must be static, public is optional. 
 * The Name of the class and the File need not be same in C#. However, its a good practise of have that naming convention to identify the locations easily. 
 */

//C# does not support global variables and functions. 
namespace SampleConApp
{
    //User defined data type. 
    internal class SampleConApp
    {
        //Entry point. It is case sensitive.
        static void Main()
        {
            //We use the .NET Framework for gettings the classes required for performing operations in our Application. 
            //Console is a class that is used to perform Console IO operations in UR App. 
            Console.WriteLine("Hello World from C#");
        }
    }
}
