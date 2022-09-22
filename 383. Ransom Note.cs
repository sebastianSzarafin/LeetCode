https://leetcode.com/problems/ransom-note/?envType=study-plan&id=data-structure-i

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int n = 'z' - 'a' + 1;
        int[] hash1 = new int[n];
        int[] hash2 = new int[n];
        for(int i = 0; i < ransomNote.Length; i++) hash1[ransomNote[i] - 'a']++;
        for(int i = 0; i < magazine.Length; i++) hash2[magazine[i] - 'a']++;
        for(int i = 0; i < n; i++)
        {
            if(hash1[i] > hash2[i]) return false;
        }
        return true;
    }
}
