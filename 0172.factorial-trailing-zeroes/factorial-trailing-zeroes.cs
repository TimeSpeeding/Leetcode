public class Solution {
    public int TrailingZeroes(int n) {
        long a = 5, ans = 0;
        while (n >= a)
        {
            ans += (long)n / a;
            a *= 5;
        }
        return (int)ans;
    }
}