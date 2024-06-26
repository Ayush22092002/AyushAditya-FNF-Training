using SampleConApp.Util;
using System;
/*
 * Exceptions are abnormal terminations that happen when a certain logic or a certain inputs are not facilitating the Application to take it forward for a smooth exit.
 * As developers, we anticipate the possible such abnormal terminations and try to resolve with exception handling. 
 * In .NET, all the possible Exceptions of an Application will be objects of a class derived from System.Exception. 
 * When the .NET Runtime throws such Exceptions, apps should have a scope to handle them using try....catch....finally. 
 * finally/catch is an optional block. U can start with try block and end with either catch, finally or both.
 * It is recommended to handle specific Exceptions instead of General Exceptions. 
 * try, catch, finally, throw are the important keywords of Exception handling in C#. 
 * try blocks can be nested within a function. 
 * U can create UR own Exception Classes by creating Classes that are derived from System.Exception.
 */
namespace SampleConApp
{

    internal class Ex17ExceptionHandling
    {
        static void Main(string[] args)
        {
            RETRY:
            Console.WriteLine("Enter the age");
            try
            {
                uint age = uint.Parse(Console.ReadLine());
                if(age < 1 || age > 100)
                {
                    throw new SampleConsoleException("Input value should be within a valid working human Age of an Adult, 18 to 100");
                }
                Console.WriteLine("The age is " + age);
            }
            catch (FormatException) 
            {
                Console.WriteLine("The input must be a valid whole number");
                goto RETRY;
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine(oEx.Message);
                goto RETRY;
            }
            catch(SampleConsoleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception actEx)
            {
                Console.WriteLine("OOPS! Something wrong happened.");
            }
            finally//This block executes on all conditions. U should not use any jump statements in the finally  block
            {
                Console.WriteLine("End of the Program. lets go for lunch");
            }
        }
    }
}
