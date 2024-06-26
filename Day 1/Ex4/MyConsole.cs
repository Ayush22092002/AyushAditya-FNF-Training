using System;

public class MyConsole
{
	public static string GetString(string question)
        {	
	System.Console.Write(question);
	return Console.ReadLine();
        }

	public static int GetInteger(string question)
	{
		int result=0;
		do{
			System.Console.WriteLine(question);
		   }while(!int.TryParse(Console.ReadLine(),out result));
		   return result;	
	}

	
	public static double GetDouble(string question)
	{
		double result=0;
		do{
			System.Console.WriteLine(question);
		   }while(!double.TryParse(Console.ReadLine(),out result));
		   return result;
	}
		
}