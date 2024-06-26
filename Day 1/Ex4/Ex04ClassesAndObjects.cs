using System;
namespace SampleConApp
{

class Machine
{
public string SlNo{get;set;}
public string Make{get;set;}
public string Model{get;set;}
public int Price{get;set;}
public override string ToString()
{
return string.Format("The Slno:{0}\n The Make:{1}\n The Model:{2}\n The Price{3}",this.SlNo,this.Make,this.Model,this.Price);
}
}


class Ex04ClassesAndObjects
{
	static void Main(string[] args)
{
	var slno=MyConsole.GetString("Enter the SL no of the Laptop=");
	var make=MyConsole.GetString("Enter the Make of the Laptop=");
	var model=MyConsole.GetString("Enter the Model of the Laptop=");
	var price=MyConsole.GetInteger("Enter the Price of the Laptop=");

	var myMachine=new Machine{SlNo=slno,Make=make,Model=model,Price=price};
	
	System.Console.WriteLine(myMachine);
}
}

}
