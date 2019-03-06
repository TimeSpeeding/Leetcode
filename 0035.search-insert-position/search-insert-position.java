class Solution {
    public int searchInsert(int[] nums, int target) {
        int l1 = nums.length;
        if(l1 == 0 || target == 0) return 0;
        int p = 0;
        for (int i = 0; i < l1; i++)
        {
            if (target <= nums[i]) break;
            else p++;
        }
        return p;
    }
}