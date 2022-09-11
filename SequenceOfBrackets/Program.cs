// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
public class BracketSequence {
	

	static Boolean isBracketsMatching(char char1, char char2)
	{
		if (char1 == '(' && char2 == ')')
			return true;
		else if (char1 == '{' && char2 == '}')
			return true;
		else if (char1 == '[' && char2 == ']')
			return true;
		else
			return false;
	}

	static string checkBracketsSequence(char[] seqExp)
	{
		Stack<char> st = new Stack<char>();

		for (int i = 0; i < seqExp.Length; i++) {
			if (seqExp[i] == '{' || seqExp[i] == '(' || seqExp[i] == '[')
				st.Push(seqExp[i]);

			if (seqExp[i] == '}' || seqExp[i] == ')' || seqExp[i] == ']') {
				if (st.Count == 0) {
					return "too many closing brackets";
				}
				else if (!isBracketsMatching(st.Pop(), seqExp[i])) {
					return "outer brackets closed before inner brackets have closed";
				}
			}
		}
		
		if (st.Count == 0)
			return "balanced"; 
		else {
			return "too many opening brackets";
		}
	}

	public static void Main(String[] args)
	{
        string? continueValidation=string.Empty;
        do{
       string? value= Console.ReadLine();
		char[] sequenceExpression = value!.ToCharArray();


        Console.WriteLine(checkBracketsSequence(sequenceExpression));
        Console.WriteLine("\npress 'y' to continue the validation...");
        continueValidation= Console.ReadLine();
        }while(continueValidation!.ToLower()=="y");
        		
	}
}

