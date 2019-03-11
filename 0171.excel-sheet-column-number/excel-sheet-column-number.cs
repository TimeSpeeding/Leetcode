public class Solution {
    public int TitleToNumber(string s) {
        int ans = 0;
        for (int i = 0; i < s.Length; i++)
        {
            ans = ans * 26 + (s[i] - 'A' + 1);
        }
        return ans;
    }
}