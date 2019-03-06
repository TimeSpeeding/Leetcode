public class Solution {
    public int LongestOnes(int[] A, int K) {
        int res = 0, zero = 0, left = 0;
        for (int right = 0; right < A.Length; ++right) {
            if (A[right] == 0) ++zero;
            while (zero > K) {
                if (A[left++] == 0) --zero;
            }
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}