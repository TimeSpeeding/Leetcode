class Solution {
    public int strStr(String haystack, String needle) {
        int l1 = haystack.length();
        int l2 = needle.length();
        if (l2 == 0) return 0;
        if (l2 > l1) return -1;
        return haystack.indexOf(needle);
    }
}