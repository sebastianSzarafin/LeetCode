https://leetcode.com/problems/first-unique-character-in-a-string/?envType=study-plan&id=data-structure-i

public class Solution {
    public int FirstUniqChar(string s) {
        int n = 'z' - 'a' + 1;
        int[] hash = new int[n];
        for(int i = 0; i < s.Length; i++) hash[s[i] - 'a']++;
        int first = 0;
        // for longer strings
        // while(first < n && hash[first] != 1) first++;
        // if(first == n) return -1;
        for(int i = 0; i < s.Length; i++) 
        {
            if(hash[s[i] - 'a'] == 1) return i;
        }
        return -1;
    }
}
