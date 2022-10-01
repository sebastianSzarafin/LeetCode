https://leetcode.com/problems/last-stone-weight/?envType=study-plan&id=level-1

public class Solution {
    public int LastStoneWeight(int[] stones) {
            List<int> stonesSorted = new List<int>(stones);
            stonesSorted.Sort();
            int n = stonesSorted.Count;
            while(n > 1)
            {
                int y = stonesSorted[n - 1];
                int x = stonesSorted[n - 2];
                if(x == y)
                {
                    stonesSorted.RemoveAt(n - 1);
                    stonesSorted.RemoveAt(n - 2);
                    n -= 2;
                }
                else
                {
                    stonesSorted.RemoveAt(n - 1);
                    stonesSorted.RemoveAt(n - 2);
                    n--;
                    y -= x;
                    int index = stonesSorted.FindIndex(stone => stone > y);
                    if(index != -1) stonesSorted.Insert(index, y);
                    else stonesSorted.Insert(n - 1, y);
                }
            }
            return stonesSorted.Sum();
        }
}
