using System;
namespace SampleConApp
{
	class Ex02ArraysExample
 {

	static void Main(string[] args)
   {
	
	/* Console.WriteLine("Enter the size of the array");
	int size=int.Parse(Console.ReadLine());
	
	int [] elements=new int[size];
	
	for(int i=0;i<size;i++)
	{
		Console.WriteLine("Enter the value at position {0}",i);
		elements[i]=int.Parse(Console.ReadLine());
	}
	Console.WriteLine("All Values are set");
		
	foreach(var item in elements)
		{
			System.Console.WriteLine(item);
		}*/

		ArrayAtRuntime();


   }

		static void creating ArrayAtRuntime()
		{
			System.concole.WriteLine("Enter the size of the array");
			int size=int.Parse(Console.ReadLine());

			Type arrayType==Type.GetType(Console.ReadLine());
			if(arrayType==null)
			{
				System.Console.WriteLine("Not a valid Data type of .Net");
				return;
			}

			Array array=Array.CreateInstance(arrayType,size);
			for(int i=0;i<size;i++)
			{
				System.Console.WriteLine("Enter the value for the position {0} of the type {1}",arrayType.FullName);
				object value=Convert.ChangeType(Console.ReadLine(),arrayType);
				array.SetValue(value,i);
			}
			System.Console.WriteLine("All value are set,Lets Read them");
			foreach(var item in array)
		        {
			System.Console.WriteLine(item);
		        }
		}
}
}