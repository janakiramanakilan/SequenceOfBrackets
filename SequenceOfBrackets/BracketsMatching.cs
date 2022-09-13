namespace SequenceOfBrackets;

public class BracketsMatching
{
public static Boolean IsBracketsMatching(char char1, char char2)
	{
		
		// if (char1 == '(' && char2 == ')')
		// 	return true;
		// if (char1 == '{' && char2 == '}')
		// 	return true;
		// if (char1 == '[' && char2 == ']')
		// 	return true;
		// return false;

		//using Switch expression
		string? brackets= char1.ToString() + char2.ToString();
		bool check= brackets switch 
		{
			"()"=> true,
			"[]"=> true,
			"{}"=> true,
			_=> false
			
		};
		return check;
	
	}
	
}