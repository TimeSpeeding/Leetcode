public class Solution {
    public int MergeStones(int[] stones, int K) {
        int n = stones.Length;
        int[] sum = new int[n + 1];
        for (int i = 1; i < n + 1; i++) sum[i] = sum[i - 1] + stones[i - 1];
        int[,,]dp = new int[205,205,205];
        int maax = 1000000000;
        for(int i = 1; i <= n; i++)
            for(int j = 1; j <= n; j++)
                for(int k = 1; k <= n; k++)
                    dp[i,j,k] = maax;
        for (int i = 1; i <= n; i++) dp[i,i,1] = 0;
        for (int len = 1; len <= n; len++) {
            for (int i = 1; i + len - 1 <= n; i++) {
                int j = i + len - 1;
                for (int k = 2; k <= len; k++) {
                    for (int t = i; t + 1 <= j; t++) {
                        dp[i,j,k] = Math.Min(dp[i,j,k], dp[i,t,k-1] + dp[t+1,j,1]);
                    }
                }
                dp[i,j,1] = Math.Min(dp[i,j,1], dp[i,j,K] + sum[j] - sum[i-1]); 
            }
        }
        if (dp[1,n,1] >= maax) return -1;
        return dp[1,n,1];
    }
}