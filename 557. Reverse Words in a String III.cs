https://leetcode.com/problems/reverse-words-in-a-string-iii/

public class Solution {
    public char[] ReverseString(char[] s) {
        int n = s.Length;
        for(int i = 0; i < n / 2; i++)
        {
            (s[i], s[n - 1 - i]) = (s[n - 1 - i], s[i]);
        }
        return s;
    }
    
    public string ReverseWords(string s) {
        string[] words = s.Split(" ");
        StringBuilder sb = new StringBuilder();
        foreach(var word in words) 
        {
            sb.Append(ReverseString(word.ToCharArray()));
            sb.Append(" ");
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}
