class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int[] index = {0, numbers.length - 1};
        while (numbers[index[0]] + numbers[index[1]] != target)
        {
            if (numbers[index[0]] + numbers[index[1]] < target) index[0]++;
            else index[1]--;
        }
        index[0]++; index[1]++;
        return index;
    }
}