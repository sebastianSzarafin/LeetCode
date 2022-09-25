https://leetcode.com/problems/valid-parentheses/?envType=study-plan&id=data-structure-i

public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        Stack<char> S = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[') S.Push(s[i]);
            else 
            {
                if(S.Count == 0) return false;
                char c = S.Pop();
                switch(c)
                {
                    case '(':
                        if(s[i] != ')') return false;
                        break;
                    case '{':
                        if(s[i] != '}') return false;
                        break;
                    case '[':
                        if(s[i] != ']') return false;
                        break;
                }
            }
        }
        if(S.Count != 0) return false;
        return true;
    }
}
