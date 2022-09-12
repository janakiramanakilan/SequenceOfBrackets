// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
namespace SequenceOfBrackets;

public class Program 
{
	public static void Main(string[] args)
	{
	try
	{
        string? value=string.Empty;
        do
		{
			Console.WriteLine("\nEnter the validation sequence or Press 'x' to Exit the validation...");
       		value = Console.ReadLine();
			char[] sequenceExpression = value!.Trim().ToCharArray();
			if (string.IsNullOrEmpty(value)) break;
			Console.WriteLine(BracketsSequence.CheckBracketsSequence(sequenceExpression));
        }while(value!.Trim().ToLower()!="x");
    }
	catch(Exception ex)
	{
			Console.WriteLine("Please enter the valid bracket sequence");
	}	
	}
}

