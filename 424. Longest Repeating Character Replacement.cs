https://leetcode.com/problems/longest-repeating-character-replacement/?envType=study-plan&id=level-1

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int len = 0, start = 0, mostCommon = 0;
        int[] letters = new int['Z' - 'A' + 1];
        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - 'A']++;
            mostCommon = Math.Max(letters[s[i] - 'A'], mostCommon);
            if ((i - start + 1) - mostCommon > k)
            {
                letters[s[start] - 'A']--;
                start++;
            }
            len = Math.Max(len, i - start + 1);
        }
        return len;
    }
}
