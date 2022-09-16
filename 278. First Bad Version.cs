https://leetcode.com/problems/first-bad-version/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(n == 1) return 1;
        int start = 1, end = n;
        while(start <= end)
        {
            int middle = start + (end - start)/2;
            if(IsBadVersion(middle))
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }
        return start;
    }
}

