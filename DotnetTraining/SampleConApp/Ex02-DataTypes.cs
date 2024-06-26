using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * C# follows the Type System of .NET Framework. 
 * .NET Framework defines 2 kinds of data : Value Types and Reference types.
 * Value types are primitive types: The types that are common among the developer community: byte, short, int, long, float, double, decimal, char, bool. All structs are value types(DateTime). 
 * Reference types: String, Array, or any class is a reference type. The values hold the address of the value, not the value itself. 
 * All value types will have wrapper types to perform conversion operations and few of the common functionalalities like string transformation, getting max and min values and few more. 
 * integral types: byte(Byte), short(Int16), int(Int32), long(Int64)
 * Floating types: float(Single), double(Double), decimal(Decimal)
 * Other Types: char(Char), bool(Boolean). 
 * Implicit casting happens when a lower range data type is assigned to a larger range data type.
 * Explicit casting(Casting operator) is required when U want to push the larger range data into a smaller range data type. U should be aware that the extended values will be cutoff from the data while converting. It is unsafe. 
 * For safe casting, U should use Convert class which has static functions to do conversions from one type to another. Its overloaded methods allow to convert from any .NET type to another .NET type if the conversion is possible, else it would throw InvalidCastException and it is safe. 
 * Before the Convert Class came into existance(.NET 4), we used to have checked block to ensure safe casting and throw exceptions for Arithematic Overflows. We also have unchecked block also. 
 * Any data type can be converted from String using Parsing. Every Value Type has a method called Parse that takes input of String and converts to its Type. 
 */
namespace SampleConApp
{
    internal class DataTypes
    {
        static void DisplayRangesOfTypes()
        {
            Console.WriteLine($"The Min value for byte is {byte.MinValue} and Max value is {byte.MaxValue}");
            Console.WriteLine($"The Min value for short is {short.MinValue} and Max value is {short.MaxValue}");
            Console.WriteLine($"The Min value for int is {int.MinValue} and Max value is {int.MaxValue}");
            Console.WriteLine($"The Min value for long is {long.MinValue} and Max value is {long.MaxValue}");
            Console.WriteLine($"The Min value for float is {float.MinValue} and Max value is {float.MaxValue}");
            Console.WriteLine($"The Min value for double is {double.MinValue} and Max value is {double.MaxValue}");
            Console.WriteLine($"The Min value for decimal is {decimal.MinValue} and Max value is {decimal.MaxValue}");
            Console.WriteLine($"The Min value for char is {char.MinValue} and Max value is {char.MaxValue}");
        }
        static void Main(string[] args)
        {
            //DisplayRangesOfTypes();
            //DataTypeDeclarationSyntax();
            //DataTypeConversionExample();
            //DateTimeExample();
            //DataParsingExample();
        }

        private static void DataParsingExample()
        {
            Console.WriteLine("Enter a number");
            int value = int.Parse( Console.ReadLine() );//ReadLine is a method of Console class to take input from the Console and return a string representation of it.
            Console.WriteLine("The Entered value is " + value);
        }

        //DateTime is a struct that represents a Date and Time. 
        private static void DateTimeExample()
        {
            Console.WriteLine("The System Date is " + DateTime.Now);
            DateTime dt = DateTime.Now;
            Console.WriteLine($"The Year factor is {dt.Year}");
            Console.WriteLine($"The Month factor is {dt.Month}");
            Console.WriteLine($"The day factor is {dt.Day}");
            Console.WriteLine($"The Hour factor is {dt.Hour}");
            Console.WriteLine("The Long format of date: " + dt.ToLongDateString());
            Console.WriteLine("The Long format of time: " + dt.ToLongTimeString());
            Console.WriteLine("The Custom Format: " + dt.ToString("dd/MMM/yy HH:mm"));
        }

        private static void DataTypeConversionExample()
        {
            int value1 = 123;
            Console.WriteLine($"The int: {value1}");
            double dValue = value1;//Conversion is implicit(Automatic).
            Console.WriteLine($"The double: {dValue +0.234}");
            long longValue = value1;
            checked
            {
                value1 = (int)(longValue + 2342234244342343245);
            }
            //value1 = (int)dValue++;//Explicit cast.
            //value1 = Convert.ToInt32( longValue + 2342234244342343245);
            Console.WriteLine($"The int: {value1} after casting from long");
            int safeValue = Convert.ToInt32(dValue);
            Console.WriteLine($"The converted value is {safeValue}");
        }

        private static void DataTypeDeclarationSyntax()
        {
            //Data Type identifier = value.
            int x = 1;
            string value = x.ToString();
            int y = 2;
            Console.WriteLine("The value of x and y are " + x + " and " + y);
            Console.WriteLine("The value is {0} for x and {1} for y. Let me tell U again, that the values of x and y are {0} and {1}", x, y);
            Console.WriteLine($"The Value of x is {x} and the value of y is {y}");

            long lValue = 12312312321;
            Console.WriteLine("The long value is " + lValue);
        }
    }
}
