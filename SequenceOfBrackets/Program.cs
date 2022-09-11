// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
namespace SequenceOfBrackets;

public class Program {
	public static void Main(string[] args)
	{
	
        string? value=string.Empty;
        do{
			Console.WriteLine("\nEnter the validation sequence or Press 'x' to Exit the validation...");
       		value = Console.ReadLine();
			char[] sequenceExpression = value!.ToCharArray();
			if (value!.ToLower()!="x")
			{
			try{
				Console.WriteLine(BracketsSequence.CheckBracketsSequence(sequenceExpression));
			}
			catch(Exception ex){
				Console.WriteLine(ex.Message);
			}
			}
        }while(value!.ToLower()!="x");
        		
	}
}

