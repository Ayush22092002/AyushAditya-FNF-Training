using System;
namespace SampleConApp
{
	class SampleExample
 {

	static void display()
   {
	Console.WriteLine("Hello World");
	Console.WriteLine("My name is Ayush Aditya");
	Console.WriteLine("I am from Bangalore");
        Console.WriteLine("I work on .NET");
   }
	static void inputExample()
	{	
		Console.WriteLine("Enter ur name");
		string name=Console.ReadLine();
		
		Console.WriteLine("Enter ur phone");
		string phone=Console.ReadLine();

		Console.WriteLine("Enter ur age");
		int age=int.Parse(Console.ReadLine());

		Console.WriteLine("The name is {0} with contact no {1} and aged {2}",name,phone,age);

		Console.WriteLine("Mr. {0}'s age will be {1} after 15 years",name,(age+15));

       }

		static void Main(){
				//display();
			inputExample();}
 }
}