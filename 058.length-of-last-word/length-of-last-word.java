class Solution {
    public int lengthOfLastWord(String s) {
        s = s.trim();
        int space = s.lastIndexOf(" ");
        int len = s.length();
        if(space == -1) return len;
        else return len - space - 1;
    }
}