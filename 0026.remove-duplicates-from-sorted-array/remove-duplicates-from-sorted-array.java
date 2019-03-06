class Solution {
    public int removeDuplicates(int[] nums) {
        if (nums.length < 2) return nums.length;
        int newlen = 0;
        for (int i = 1; i < nums.length; i++)
            if(nums[i] != nums[newlen])
                nums[++newlen] = nums[i];
        return newlen + 1;
    }
}