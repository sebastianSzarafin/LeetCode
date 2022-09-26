https://leetcode.com/problems/combinations/?envType=study-plan&id=algorithm-i

public class Solution {
    public List<IList<int>> subsets = new List<IList<int>>();
    public List<int> subset = new List<int>();
    public void GenerateSubset(int n, int k, int i)
    {
        if(subset.Count == k) subsets.Add(subset.ToList());
        for(int m = i; m <= n; m++)
        {
            subset.Add(m);
            GenerateSubset(n, k, m + 1);
            subset.Remove(m);
        }
    }
    
    public IList<IList<int>> Combine(int n, int k) {
        GenerateSubset(n, k, 1);
        return subsets;
    }
}
