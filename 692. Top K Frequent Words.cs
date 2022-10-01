https://leetcode.com/problems/top-k-frequent-words/?envType=study-plan&id=level-1

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> d = new Dictionary<string, int>();
        for(int i = 0; i < words.Length; i++)
        {
            if(d.ContainsKey(words[i])) d[words[i]]++;
            else d.Add(words[i], 1);
        }
        List<string> toReturn = new List<string>();
        foreach(var item in d.OrderByDescending(w => w.Value).ThenBy(w => w.Key))
        {
            if(k-- == 0) break;
            toReturn.Add(item.Key);
        }
        return toReturn;
    }
}
