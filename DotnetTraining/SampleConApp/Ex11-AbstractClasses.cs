using System;
/*
 * An abstract class is one that has atleast one abstract method. 
 * An Abstract method is a method that has no body in it. 
 * As the class is incomplete, this class cannot be instantiated. 
 * Abstract classes must be inherited, so that U can implement those abstract methods in them and thru' Runtime Polymorphism, U can invoke other members of the class. 
 * If a Class is deriving from an Abstract class, it must implement all the abstract methods, else even this class must be declared as abstract.
 * Abstract classes can have normal methods,virtual methods and even overriden methods along with atleast one abstract method. 
 * A Similar component that makes all the derived classes to have a rule that it must implement all the methods of the class without marking them as abstract. 
 */
namespace SampleConApp
{
    abstract class Account
    {
        public long AccountNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; private set; }
        public void CreditAmount(double amount)
        {
            Balance += amount;
        }

        public void DebitAmount(int amount)
        {
            if(Balance < amount)
            {
                throw new Exception("Insufficient Funds");
            }
            Balance -= amount;
        }

        public abstract void CalculateInterest();
    }

    class SBAccount : Account
    {
        //abstract methods must be implemented using override keyword. 
        public override void CalculateInterest()
        {
            var principal = Balance;
            var term = 0.25;
            var interestRate = 0.065;
            var interest = principal * term * interestRate;
            CreditAmount(interest);
        }
    }
    //todo: Implement FDAccount and RDAccount class with appropriate logic for interest calculations on those respective account types. 
    //Create a factory class that returns the specific account type and performs the interest calculations at runtime and display the updated Balance of that account.
    internal class Ex11_AbstractClasses
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount();
            acc.AccountNo = 23442434;
            acc.Name = "TestName";
            acc.CreditAmount(4000);
            acc.CalculateInterest();
            Console.WriteLine("The Current Balance is {0}", acc.Balance);
        }
    }
}
