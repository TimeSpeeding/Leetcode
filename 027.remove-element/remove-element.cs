public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int newlen = 0;
        for (int i = 0; i < nums.Length; i++)
            if(nums[i] != val)
                nums[newlen++] = nums[i];
        return newlen;
    }
}