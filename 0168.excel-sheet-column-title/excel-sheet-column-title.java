class Solution {
    public String convertToTitle(int n) {
        String[] a = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        String ans = "";
        while(n > 0)
        {
            n--;
            ans = a[n % 26] + ans;
            n /= 26;
        }
        return ans;
        /* StringBuilder ans = new StringBuilder();
        while (n > 0)
        {
            n--;
            ans.insert(0, (char)('A' + n % 26));
            n /= 26;
        }
        return ans.toString();*/
    }
}