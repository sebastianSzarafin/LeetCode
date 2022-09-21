https://leetcode.com/problems/longest-substring-without-repeating-characters/?envType=study-plan&id=algorithm-i

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] ascii = new int[128];
        string maxSubs = "", subs = "";
        for(int i = 0; i < s.Length; i++)
        {
            if(ascii[s[i]] == 0)
            {
                subs += s[i];
                ascii[s[i]]++;
                if(maxSubs.Length < subs.Length) maxSubs = subs;
            }
           else 
           {
               i -= subs.Length;
               subs = "";
               Array.Clear(ascii, 0, ascii.Length);
           }
        }
        return maxSubs.Length;
    }
}
