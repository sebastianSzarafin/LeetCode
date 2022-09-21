https://leetcode.com/problems/longest-palindrome/?envType=study-plan&id=level-1

public class Solution {
    public int LongestPalindrome(string s) {
        int n = 'z' - 'a' + 1;
        int[] smallLetters = new int[n];
        int[] bigLetters = new int[n];
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] >= 'a' && s[i] <= 'z') smallLetters[s[i] - 'a']++;
            else bigLetters[s[i] - 'A']++;
        }
        int length = 0;
        for(int i = 0; i < n; i++)
        {
            if(smallLetters[i] % 2 == 0) 
            {
                length += smallLetters[i];
                smallLetters[i] = 0;
            }
            else 
            {
                length += smallLetters[i] - 1;
                smallLetters[i] = 1;
            }
            if(bigLetters[i] % 2 == 0) 
            {
                length += bigLetters[i];
                bigLetters[i] = 0;
            }
            else
            {
                length += bigLetters[i] - 1;
                bigLetters[i] = 1;
            }
                
        }
        for(int i = 0; i < n; i++)
        {
            if(smallLetters[i] % 2 == 1)
            {
                length += 1;
                break;
            }
            if(bigLetters[i] % 2 == 1) 
            {
                length += 1;
                break;
            }
        }
        return length;
    }
}
