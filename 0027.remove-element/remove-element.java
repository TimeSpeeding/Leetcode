class Solution {
    public int removeElement(int[] nums, int val) {
        int newlen = 0;
        for (int i = 0; i < nums.length; i++)
            if(nums[i] != val)
                nums[newlen++] = nums[i];
        return newlen;
    }
}