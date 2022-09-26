https://leetcode.com/problems/letter-case-permutation/?envType=study-plan&id=algorithm-i

public class Solution {
    public List<string> permutations = new List<string>();
    public void GeneratePermutation(string s, StringBuilder sb, int i)
    {
        if(i == s.Length)
        {
            permutations.Add(sb.ToString());
            return;
        }
        if(Char.IsLetter(s[i]))
        {
            sb.Append(Char.ToLower(s[i]));
            GeneratePermutation(s, sb, i + 1);
            sb.Remove(sb.Length - 1, 1);
            
            sb.Append(Char.ToUpper(s[i]));
            GeneratePermutation(s, sb, i + 1);
            sb.Remove(sb.Length - 1, 1);
        }
        else
        {
            sb.Append(s[i]);
            GeneratePermutation(s, sb, i + 1);
            sb.Remove(sb.Length - 1, 1);
        }
    }
    
    public IList<string> LetterCasePermutation(string s) {
        StringBuilder sb = new StringBuilder();
        GeneratePermutation(s, sb, 0);
        return permutations;
    }
}
