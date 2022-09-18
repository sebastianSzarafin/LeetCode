https://leetcode.com/problems/isomorphic-strings/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        
        int i = 0;
        List<int>[] mapS = new List<int>[128];
        for(i = 0; i < 128; i++) mapS[i] = new List<int>();        
        for(i = 0; i < s.Length; i++) mapS[s[i]].Add(i);
        List<int>[] mapT = new List<int>[128];
        for(i = 0; i < 128; i++) mapT[i] = new List<int>();
        for(i = 0; i < t.Length; i++) mapT[t[i]].Add(i);
        
        i = 0;
        while(i < 128)
        {
            if(mapS[i].Count == 0) 
            {
                i++;
                continue;
            }
            int j = 0;
            bool cond = false;
            while(j < 128)
            {
                if(mapS[i].Count == mapT[j].Count && 
                   Enumerable.SequenceEqual(mapS[i], mapT[j])) 
                {
                    cond = true;
                    break;
                }
                j++;
            }
            if(!cond) return false;
            i++;
        }
        return true;
    }
}
