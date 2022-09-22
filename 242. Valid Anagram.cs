https://leetcode.com/problems/valid-anagram/?envType=study-plan&id=data-structure-i

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int n = 'z' - 'a' + 1;
        int[] hash1 = new int[n];
        int[] hash2 = new int[n];
        for(int i = 0; i < s.Length; i++) 
        {
            hash1[s[i] - 'a']++;
            hash2[t[i] - 'a']++;
        }
        for(int i = 0; i < n; i++)
        {
            if(hash1[i] != hash2[i]) return false;
        }
        return true;
    }
}
