public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        s = s.ToLower();
        string ss = "";
        for (int i = 0; i < s.Length; i++)
            if ((s[i] <= 'z' && s[i] >= 'a') || (s[i] <= '9' && s[i] >= '0'))
                ss += s.Substring(i, 1);
        int len = ss.Length;
        for (int i = 0; i < len / 2; i++)
            if (ss[i] != ss[len - 1 - i])
                return false;
        return true;
    }
}