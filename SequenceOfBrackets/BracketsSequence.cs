namespace SequenceOfBrackets;

public class BracketsSequence
{
	public static string CheckBracketsSequence(char[] seqExp)
	{
		Stack<char> st = new Stack<char>();
		for (int i = 0; i < seqExp.Length; i++) {
			if ( IsOpeningBracket(seqExp[i]))
				st.Push(seqExp[i]);

			if (IsClosingBracket(seqExp[i])) {
				if (st.Count == 0) {
					return "too many closing brackets";
				}
				if (!BracketsMatching.isBracketsMatching(st.Pop(), seqExp[i])) {
					return "outer brackets closed before inner brackets have closed";
				}
			}
		}
		
		if (st.Count == 0)
			return "balanced"; 
		
		return "too many opening brackets";
		
	}
    public static bool IsOpeningBracket(char input) => "({[".Any(c => c == input);
    public static bool IsClosingBracket(char input) => ")}]".Any(c => c == input);

}