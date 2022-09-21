https://leetcode.com/problems/permutation-in-string/?envType=study-plan&id=algorithm-i

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int[] t1 = new int['z' - 'a' + 1];
        int[] t2 = new int['z' - 'a' + 1];
        for(int i = 0; i < s1.Length; i++) t1[s1[i] - 'a']++;
        for(int i = 0; i <= s2.Length - s1.Length; i++)
        {
            Array.Clear(t2, 0, t2.Length);
            string subs = s2.Substring(i, s1.Length);
            for(int j = 0; j < subs.Length; j++) t2[subs[j] - 'a']++;
            if(t1.SequenceEqual(t2)) return true;
        }
        return false;
    }
}
