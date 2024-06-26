using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex20_BasicRecaps
    {
        //foreachStatement
        static void foreachExample()
        {
            //foreach is used for iterating. It will always iterate within the bounds of the collection. It can iterate only by 1 element at a time. It is forward only and read only. foreach can be used only on collections like arrays...
            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            foreach (int element in elements)
            {
                Console.WriteLine(element);
            }
        }


        static void ConstantsExample()
        {
            //Constants optimize the execution of the program as it is evaluated at compile time and the runtime will use it like a literal where ever U use it in the program without a need to reevaluate it, hense optimized. 
            int radius = 10;
            const double pi = 3.14;
            var areaOfCircle = pi * radius * radius;
            Console.WriteLine("The area: " + areaOfCircle);
        }

        static void Main(string[] args)
        {
            ConstantsExample();
            //foreachExample();
        }
    }
}
