public class Solution {
    public int StrStr(string haystack, string needle) {
        int l1 = haystack.Length;
        int l2 = needle.Length;
        if (l2 == 0) return 0;
        if (l2 > l1) return -1;
        for (int i = 0; i <= l1 - l2; i++)
        {
            if(needle.CompareTo(haystack.Substring(i, l2)) == 0) return i;
        }
        return -1;
    }
}