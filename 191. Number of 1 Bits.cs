https://leetcode.com/problems/number-of-1-bits/?envType=study-plan&id=algorithm-i

public class Solution {
    public int HammingWeight(uint n) {
        int ones = 0;
        while(n != 0)
        {
            if((n & 1) == 1) ones++;
            n >>= 1;
        }
        return ones;
    }
}
