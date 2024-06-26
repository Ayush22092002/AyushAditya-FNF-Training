using System;
/*
 * The Simplest form of collection of data is Array. 
 * Arrays in C# are objects of a class called System.Array. 
 * Arrays hold the group of objects making it easy to refer a collection using index. index starts with 0 in C#. It cannot be changed. 
 * Arrays are fixed in size. For modifying the array count, U should either create a new Array or use Collection classes. 
 * Arrays are reference types in C#. 
 * U can use the static and non static methods of the Array class to get info, about the Array, Cloning the Array, copying the array into another and many common operations required while working with collections. 
 * Jagged Array is an array of arrays, where U have a fixed no of rows but variable no of columns in each row. A School is an array of classrooms and each room has variable no of students. 
 */

namespace SampleConApp
{
    internal class Ex05_ArraysExample
    {
        static void Main(string[] args)
        {
            //SingleDimensionalArray();
            //MultiDimensionalArray();
            //JaggedArrayExample();
            //CreatingDynamicArray();
            //todo: Clone, Copy, CopyTo. other than the normal = operator. 
        }

        private static void CreatingDynamicArray()
        {
            //I want the size of the array to be set at runtime and the datatype of the array should be set at runtime. 
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CTS(Common Type System) Data type of the array");
            string inputDataType = Console.ReadLine();
            //Creating an Array using Array class. 
            Type type = Type.GetType(inputDataType);
            if (type == null)
            {
                Console.WriteLine("Input type is not a valid data type of .NET Framework, So we cannot create an Array");
                return;
            }
            //All .NET types are derived from a class System.object. It is the base type for all. All C# types are .NET Types
            Array array = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value for the array element at the location {0} of the data type {1}", i, type.Name);
                string value = Console.ReadLine();
                object setValue = Convert.ChangeType(value, type);
                array.SetValue(setValue, i);
            }
            Console.WriteLine("All the values are set, lets read them...");
            foreach (object element in array)
            {
                Console.WriteLine(element);
            }
        }
        private static void JaggedArrayExample()
        {
            int[][] School = new int[3][];//Defines the rows(fixed)
            School[0] = new int []{ 45,56,66,77,88 };
            School[1] = new int []{ 45,56,66,77,88, 78, 66, 90,45,66 };
            School[2] = new int []{ 45,56,66,77 };

            for (int i = 0; i < School.Length; i++)
            {
                foreach(int score in School[i])
                {
                    Console.Write(score + "   ");
                }
                Console.WriteLine();
            }
        }

        private static void MultiDimensionalArray()
        {
            int[,] TwoDArray = { 
                                { 1, 2, 3, 4 }, 
                                { 2, 3, 4, 5 }, 
                                { 3, 4, 5, 6 } 
                              };
            Console.WriteLine("The no of dimensions: " + TwoDArray.Rank);
            Console.WriteLine("The length of the 1st dimension is " + TwoDArray.GetLength(0));
            Console.WriteLine("The length of the 2nd dimension is " + TwoDArray.GetLength(1));
            Console.WriteLine("The total no of elements within the array is " + TwoDArray.Length);

            Console.WriteLine("Displaying in matrix format");
            for (int i = 0; i < TwoDArray.GetLength(0); i++) {
                for (int j = 0; j < TwoDArray.GetLength(1); j++) {
                    Console.Write(TwoDArray[i, j] + ",");
                }
                Console.WriteLine();
            }
        }

        private static void SingleDimensionalArray()
        {
            //datatype [] identifier = new datatype[size];
            int[] scores = new int[5]; //declaring the array...
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Enter the value for the {0}th no", i);
                scores[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in scores)
            {
                Console.WriteLine(i);
            }
        }
    }
}
