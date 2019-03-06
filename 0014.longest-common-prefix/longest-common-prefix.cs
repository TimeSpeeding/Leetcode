public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length < 1 || strs == null) return "";
        if (strs.Length == 1) return strs[0];
        int shortest = 0;
        int len = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            int cutlen = strs[i].Length;
            if (cutlen < len)
            {
                len = cutlen;
                shortest = i;
            }
        }
        string com = strs[shortest];
        for (int i = 0; i < strs.Length; i++)
        {
            while(strs[i].IndexOf(com) != 0)
            {
                com = com.Substring(0, com.Length - 1);
            }
            if (com == "") break;
        }
        return com;
    }
}