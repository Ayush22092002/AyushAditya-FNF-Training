using System;

/*
 * Inheritance in OOP is based on a Principle called OPEN-CLOSED Principle. 
 * A Class is closed for modification, but Open for Extension. 
 * Classes are immutable. So if U intend to add/modify any function of a given class, U should not do it. Instead U can extend the class using the feature of Inheritance and modify or add functions. It is OPEN for Extension. 
 * In C#, we have Single Inheritance where UR class can inherit only one class at any level. Unlike C++.  
 * C# supports Multi level inheritance. It does not support Multiple Inheritance. 
 * Multiple Interface Inheritance is available. Covered in Interface Example. 
 * C# has only general inheritance, it does not support private or any other kind of inheritance. 
 * All the members of the Super class will be retaining their accessibility into the Sub Classes.
 * Base class and derived class are the technical terms used in C# language.  
 */
namespace SampleConApp
{
    class SuperClass    {
        public void SuperFunc()
        {
            Console.WriteLine("Super Class method");
        }
    }

    //Most of the syntax of C# comes from C++. Assume that the Code of the Base Class is not available with U. 
    class SubClass : SuperClass
    {
        public void SubFunc() { Console.WriteLine("Sub Class method"); }
    }

    internal class Ex09_Inheritance
    {
        static void Main(string[] args)
        {
            SubClass cls = new SubClass();
            cls.SuperFunc();
            cls.SubFunc();
           
        }
    }
}
