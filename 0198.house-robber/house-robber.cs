public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        int[] ans = new int[n];
        ans[0] = nums[0];
        ans[1] = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < n; i++)
            ans[i] = Math.Max(ans[i - 1], ans[i - 2] + nums[i]);
        return ans[n - 1];
    }
}