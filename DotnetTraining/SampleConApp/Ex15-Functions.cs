using SampleConApp.Util;
using System;
using System.Runtime.InteropServices;
/*
 * Functions are set of statements that are grouped to be used frequently. 
 * There can be static and non static functions. 
 * static functions are those that can be called without creating an object of that class. 
 * Non static functions are instance specific and may contain operations that will manipulate the data of that instance.
 * Non static functions can call static methods of the class. However, the inverse of it is not possible, for that U need to create an instance and then thru' the instance U should call the methods. 
 * With the instance object, U cannot call the static methods. 
 * We use paramters to inject the dependencies for the function implementation. 
 * The outputs of the functions are typically provided as return values for the function. 
 * Usually, a function can return only one type of value. With Tuples, we can return multiple values. 
 * Functions can have parameters passed by value, reference and as out parameters. 
 * In C#, U can pass objects of a class, Arrays as parameters of the function.
 * When U want the parameter values to be retained even after the function returns, then we use ref and out parameters. WIth this, any change in the parameter values in the function will be retained even after the function returns.
 * ref expects the values to be initialized before being passed to the function. 
 * If a Function wants to pass variable no of args, then u can use params. 
 * U can have only one params type in a function. 
 * params should be the last of the parameter list. 
 * params are always passed by value. 
 */
namespace SampleConApp
{
    class MathComponent
    {
        public static void Test() => Console.WriteLine("test");
        public double AddFunction(double v1, double v2)
        {
            return (v1 + v2);
        }

        public double AddFunction(params double[] values) 
        {
            double result = 0;
            foreach (var value in values) {
                result += value;
            }
            return result;
        }
        public double SubtractFunction(double v1, double v2) => (v1 - v2);

        public double ProductFunction(double v1, double v2) => (v1 * v2);

        public double DivideFunction(double v1, double v2) => (v1 / v2);

         public void SquareOperation(double v1, ref double square, ref double squareRoot)
        {
            //out parameters are expected to be assigned in the function, as they might not be initialized in the caller's function. 
            square = ProductFunction(v1, v1);
            if(v1 != 0)
                squareRoot = Math.Sqrt(v1);
        }
    }

enum Operations
{
    Add, Subtract, Product, Divide,Square
    }
internal class Ex15Functions
{
    static void PerformOperation(Operations operation)
    {
        switch (operation)
        {
            case Operations.Add:
                AddingFeature();
                break;
            case Operations.Subtract:
                SubtractFeature();
                break;
            case Operations.Product:
                ProductFeature();
                break;
            case Operations.Divide:
                DivideFeature();
                break;
            case Operations.Square:
                SquareFeature();
                break;

        }
    }

        private static void SquareFeature()
        {
            double value = double.Parse(MyConsole.GetString("Enter the Number to perform Squaring operations"));
            double squareValue =0, squareRootValue =0;
            MathComponent component = new MathComponent();
            component.SquareOperation(value, ref squareValue, ref squareRootValue);
            Console.WriteLine("The Square of the number is {0}", squareValue);
            Console.WriteLine("The SquareRoot of the number is {0}", squareRootValue);
        }

        private static void DivideFeature()
        {
            throw new NotImplementedException();
        }

        private static void ProductFeature()
        {
            throw new NotImplementedException();
        }

        private static void SubtractFeature()
        {
            MathComponent component = new MathComponent();
            double v1 = double.Parse(MyConsole.GetString("Enter the First value to subtract"));
            double v2 = double.Parse(MyConsole.GetString("Enter the Second value to subtract"));
            var result = component.SubtractFunction(v1, v2);
            Console.WriteLine("The result of this operation is " + result);
        }

        private static void AddingFeature()
    {
        MathComponent component = new MathComponent();
        double v1 = double.Parse(MyConsole.GetString("Enter the First value to add"));
        double v2 = double.Parse(MyConsole.GetString("Enter the Second value to add"));
        var result = component.AddFunction(v1, v2);
        Console.WriteLine("The result of this operation is " + result);
    }

    static Operations GetOperations()
    {
        Array operations = Enum.GetValues(typeof(Operations));
        Console.WriteLine("Enter the Operation U want to do:");
        foreach (var item in operations)
        {
            Console.WriteLine(item);
        }
        var selectedOperation = (Operations)Enum.Parse(typeof(Operations), Console.ReadLine());
        return selectedOperation;
    }
    static void Main(string[] args)
    {
            
            Console.WriteLine("Welcome to Math Calculator");
            do
            {
                var selected = GetOperations();
                PerformOperation(selected);
            } while (true);
        }
}
}
//ToDo: Implement the rest of the functions as defined in boilerplate code. Also add a new enum field for params example and complete the Application to test all sorts of operations in the given MathComponent.