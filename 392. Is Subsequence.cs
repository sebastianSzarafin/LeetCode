https://leetcode.com/problems/is-subsequence/

public class Solution {
    
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        int i = 0;
        for(int j = 0; j < t.Length; j++)
        {
            if(s[i] == t[j]) i++;
            if(i == s.Length) return true;
        }
        return false;
    }
}
