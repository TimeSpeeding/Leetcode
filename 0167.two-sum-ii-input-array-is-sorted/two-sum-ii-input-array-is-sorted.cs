public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] index = new int[2] {0,0};
        for (int i = 0;i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    index[0] = i + 1; index[1] = j + 1;
                    break;
                }
            }
        }
        return index;
    }
}