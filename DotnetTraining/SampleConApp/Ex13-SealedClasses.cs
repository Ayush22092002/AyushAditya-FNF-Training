using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * A Class is always created to be extended further. 
 * However if U want to stop the inheritance feature, U could mark the class as sealed 
 * Sealed Classes cannot be extended further, it dissolves the very purpose of OOP. 
 * U cannot have abstract methods, override functions in it. 
 * 
 * Sealed Methods are those methods that cannot be overriden in its derived classes. 
 * U cannot have direct sealed methods, instead U can override a method and make it sealed, so that it cannot be further overriden.
 * Sealed methods need not make the declaring class as sealed. 
 */
namespace SampleConApp
{
    class NormalBaseClass
    {
        public virtual void NormalFunc()
        {
            Console.WriteLine("Normal Function is created");
        }
    }
    class SuperConcreteClass : NormalBaseClass
    {
        public override sealed void NormalFunc()
        {
            base.NormalFunc();
            Console.WriteLine("This method cannot be overriden further");
        }
        public void SealedFunc()
        {
            Console.WriteLine("Sealed Function");
        }
    }

    class SubClassForSealed : SuperConcreteClass
    {
        //override : U cannot override the overriden sealed function....
    }
    internal class Ex13_SealedClasses
    {
        static void Main(string[] args)
        {
            NormalBaseClass cls = new NormalBaseClass();
            cls.NormalFunc();
            cls = new SubClassForSealed();
            cls.NormalFunc();
        }
    }
}
