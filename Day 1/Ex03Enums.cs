using System;
namespace enumexample
{
enum AccountType
{
sbaaccount,savingsaccount,fdaaccount,caccount
}

class Ex03Enums
{
	static void Main(string[] args)
   {
	enbumInputexample();

	/*AccountType acc=AccountType.sbaaccount;
	System.Console.WriteLine("The Account selected is"+" "+acc);
	System.Console.WriteLine("The internal value of enum is="+(int)acc);*/
	
   }

	static void enbumInputexample()
{
	System.Console.WriteLine("Enter the type of account u want to create");
	var values=Enum.GetValues(typeof(AccountType));
	foreach(var item in values)
	{
		System.Console.WriteLine(item);
	}	
	string selected=Console.ReadLine();
	
	AccountType acc=(AccountType)Enum.Parse(typeof(AccountType),selected,true);
	System.Console.WriteLine("The type of account selected is="+acc);
}
}
}