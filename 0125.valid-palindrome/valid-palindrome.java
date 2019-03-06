class Solution {
    public boolean isPalindrome(String s) {
        String ss = s.replaceAll("[^A-Za-z0-9]", "").toLowerCase();
        String rev = new StringBuffer(ss).reverse().toString();
        return ss.equals(rev);
    }
}