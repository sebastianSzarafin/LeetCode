https://leetcode.com/problems/reverse-bits/?envType=study-plan&id=algorithm-i

public class Solution {
    public uint reverseBits(uint n) {
        uint reversed = 0;
        int count = 0;
        while(n > 0)
        {
            reversed <<= 1;
            if((n & 1) == 1) reversed |= 1;
            n >>= 1;
            count++;
        }
        reversed <<= 32 - count;
        return reversed;
    }
}
