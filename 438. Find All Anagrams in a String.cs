https://leetcode.com/problems/find-all-anagrams-in-a-string/

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        List<int> list = new List<int>();
        if(p.Length > s.Length) return list;
        int[] pLetters = new int['z' - 'a' + 1];
        int[] sLetters = new int['z' - 'a' + 1];
        for(int i = 0; i < p.Length; i++) 
        {
            pLetters[p[i] - 'a']++;
            sLetters[s[i] - 'a']++;
        }
        for(int i = p.Length; i < s.Length; i++)
        {
            if(pLetters.SequenceEqual(sLetters)) list.Add(i - p.Length);
            sLetters[s[i] - 'a']++;
            sLetters[s[i - p.Length] - 'a']--;
        }
        if(pLetters.SequenceEqual(sLetters)) list.Add(s.Length - p.Length);
        return list;
    }
}
