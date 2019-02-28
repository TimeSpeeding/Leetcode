class Solution {
    public int maxProfit(int[] prices) {
        int minPrice = Integer.MAX_VALUE;
        int maxPro = 0;
        for (int i = 0; i < prices.length; i++)
        {
            if (prices[i] < minPrice) minPrice = prices[i];
            else if (prices[i] - minPrice > maxPro) maxPro = prices[i] - minPrice;
        }
        return maxPro;
    }
}