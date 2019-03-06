public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0;
            int[] hash = new int[300];
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 300; j++) hash[j] = 0;
                flag = true;
                for (int j = i; j < s.Length; j++)
                {
                    if (hash[s[j]] != 0)
                    {
                        if ((j - i) > ans) ans = j - i;
                        flag = false;
                        break;
                    }
                    else hash[s[j]]++;
                }
                if (flag && (s.Length - i) > ans) ans = s.Length - i;
            }
            return ans;
    }
}