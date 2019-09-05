class Solution {
    public boolean containsDuplicate(int[] nums) {
        if (nums.length < 2) return false;
        Set<Integer> numbers = new HashSet<Integer>();
        for (int i : nums) {
            if (!numbers.add(i)) return true;
        }
        return false;
    }
}