namespace SequenceOfBrackets;

public class BracketsMatching
{
public static Boolean isBracketsMatching(char char1, char char2)
	{
		if (char1 == '(' && char2 == ')')
			return true;
		if (char1 == '{' && char2 == '}')
			return true;
		if (char1 == '[' && char2 == ']')
			return true;
		return false;
	}

	
}