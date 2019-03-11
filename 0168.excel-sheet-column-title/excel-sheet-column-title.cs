public class Solution {
    public string ConvertToTitle(int n) {
         string[] a = new string[26] {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        string ans = "";
        n--;
        while(n / 26 != 0)
        {
            ans = a[n % 26] + ans;
            n /= 26;
            n--;
        }
        ans = a[n % 26] + ans;
        return ans;
    }
}