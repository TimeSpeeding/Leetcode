public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) return nums.Length;
        int newlen = 0;
        for (int i = 1; i < nums.Length; i++)
            if(nums[i] != nums[newlen])
                nums[++newlen] = nums[i];
        return newlen + 1;
    }
}