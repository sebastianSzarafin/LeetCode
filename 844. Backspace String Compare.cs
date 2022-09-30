https://leetcode.com/problems/backspace-string-compare/?envType=study-plan&id=level-1

public class Solution {
    public bool BackspaceCompare(string s, string t) {
        Stack<char> S = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != '#') S.Push(s[i]);
            else if(S.Count != 0) S.Pop();
        }
        Stack<char> T = new Stack<char>();
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] != '#') T.Push(t[i]);
            else if(T.Count != 0) T.Pop();
        }
        if(S.Count != T.Count) return false;
        while(S.Count != 0)
        {
            if(S.Pop() != T.Pop()) return false;
        }
        return true;
    }
}
