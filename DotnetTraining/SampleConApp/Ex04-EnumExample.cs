using System;
/*
 * Enums are user defined value types that are used to refer named integers. 
 * Enums are named constants used to identify a value from a set of predefined values. Eg would be Months of an Year, Days of a week, Types of Accounts in a Banking Domain, Types of File Reading(Read, Write). 
 * Enums are helpful for providing a meaning full switch blocks in a switch case statement. 
 * Here the internal values of the Enums are integers. They  are 0 based indexed values. However, U can change them to the value U want. 
 * If U set a value to the first member, the next will have an enumerated value(Incremented by 1).
 * To work with any enum types, U have a .NET Class called System.Enum that helps U in getting/setting info about the enums dynamically. 
 */
namespace SampleConApp
{
    enum AccountType
    {
        SBAccount = 1, RDAccount, FDAccount, CCAcount, CAccount
    }
    internal class Ex04_EnumExample
    {
        /// <summary>
        /// Function to show the usage of Enum type in a switch case statement
        /// </summary>
        /// <param name="accountType">The Enum value to be used</param>
        /// <returns>The Balance amount for the enum type.</returns>
        static double GetMinBalance(AccountType accountType)
        {
            double balance = 0;
            switch (accountType)
            {
                case AccountType.SBAccount:
                    balance = 5000;
                    break;
                case AccountType.RDAccount:
                    balance = 1000;
                    break;
                case AccountType.FDAccount:
                    balance = 50000;
                    break;
                case AccountType.CCAcount:
                    balance = 5000;
                    break;
                case AccountType.CAccount:
                default:
                    break;
            }
            return balance;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the type of account U want from the List mentioned below:");
            //Get all the possible values from the AccountType enum
            Array array = Enum.GetValues(typeof(AccountType));
            //Iterate thru the valus and display on Console.
            foreach (object value in array) 
            { 
                Console.Write(value + " ") ; 
            }
            Console.WriteLine();
            ////Take the input into a string variable
            //string accType = Console.ReadLine();
            ////Parse the string to the enum type. 
            //object convertedValue = Enum.Parse(typeof(AccountType), accType, true);
            ////Unbox the object to the Enum Type. 
            //AccountType acc = (AccountType)convertedValue;

            //Try this after U learn Boxing and Unboxing.
            AccountType acc = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine()); 
            Console.WriteLine(acc);
            Console.WriteLine($"The internal data value is {(int)acc}");
            Console.WriteLine($"The Min balance for this account type is {GetMinBalance(acc)}");
        }
    }
}
