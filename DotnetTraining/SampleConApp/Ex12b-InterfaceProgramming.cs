using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * UR class can implement 2 or more interfaces at the same level. This is called as Multiple Interface Inheritance. 
 */
namespace SampleConApp
{
    interface ISimple
    {
        void SimpleFunc();
        void CreateSampleMethod();
    }

    interface IExample
    {
        void ExampleFunc();
        void CreateSampleMethod();

    }

    class SimpleExample : ISimple, IExample
    {
        public void ExampleFunc() { Console.WriteLine("Example Func"); }

        public void SimpleFunc() { Console.WriteLine("Simple Func"); }
        public void CreateSampleMethod() { Console.WriteLine("Common Sample Method"); }

        #region ExplictImplimentation
        void IExample.CreateSampleMethod()
        {
            Console.WriteLine("Example's Sample method");
        }

        void ISimple.CreateSampleMethod()
        {
            Console.WriteLine("Simple's Sample method");
        }
        #endregion
    }
    internal class Ex12b_InterfaceProgramming
    {
        static void Main(string[] args)
        {
            IExample ex = new SimpleExample();
            ex.ExampleFunc();
            ex.CreateSampleMethod();

            ISimple simple = new SimpleExample();
            simple.SimpleFunc();
            simple.CreateSampleMethod();
            
            SimpleExample example = new SimpleExample();
            example.SimpleFunc();
            example.ExampleFunc();
            example.CreateSampleMethod();
        }
    }
}
