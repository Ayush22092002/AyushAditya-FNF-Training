using System;
using System.Runtime.InteropServices;
/*
 * One of the main features of OOP is Encapsulation or Data Hiding. 
 * C# provides 5 levels of Encapsulation. 
 * Class level: Accessable only within the class(private)
 * Class and its Sub class level: Accessible within the class and its sub classes(protected).
 * Project level: Accessible by all the classes belonging to the Project(internal).
 * Subclass or Project level(Protected Internal)
 * Accessible anywhere: public. 
 * Within the class, default access specifier is private. 
 * At the project level, the default access specifier is internal. At the project level, U can have either public or internal. 
 * To  provide a level of abstraction at the operational level, we create Private functions. This will also help in better modularity. (Dividing the function into task based activities where one function will do only one task). 
 */
namespace SampleConApp
{
    class AccessSpecifer
    {
        public static void PublicFunc()
        {
            PrivateFunc();
            Console.WriteLine("Public Func calling the Private Func");
        }
        static void PrivateFunc() => Console.WriteLine("Private Function");
        protected static void ProtectedFunc() => Console.WriteLine("Protected Function");
        protected internal static void ProcInternalFunc() => Console.WriteLine("Protected Internal Function");
        internal static void InternalFunc() => Console.WriteLine("Internal Function");
    }
    class Ex08_AccessSpecifiers : AccessSpecifer
    {
        static void Main(string[] args)
        {
            AccessSpecifer.InternalFunc();//Part of the same project. 
            AccessSpecifer.ProcInternalFunc();//Either of the both. 
            AccessSpecifer.PublicFunc();
            AccessSpecifer.ProtectedFunc();
        }
    }
}
//Todo: Implement the same concept using Instance based Functions and note the differences if any. 