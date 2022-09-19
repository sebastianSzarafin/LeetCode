https://leetcode.com/problems/reverse-string/

public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        for(int i = 0; i < n / 2; i++)
        {
            (s[i], s[n - 1 - i]) = (s[n - 1 - i], s[i]);
        }
    }
}
