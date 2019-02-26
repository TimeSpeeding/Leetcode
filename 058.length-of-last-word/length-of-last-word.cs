public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ') len++;
            else break;
        }
        return len;
    }
}