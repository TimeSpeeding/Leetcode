public class Solution {
    public string AddBinary(string a, string b) {
        string ans = "";
        int i = a.Length - 1, j = b.Length - 1, carry = 0;
        while (i >= 0 || j >= 0)
        {
            int sum = carry;
            if (j >= 0) sum += b[j--] - '0';
            if (i >= 0) sum += a[i--] - '0';
            ans = (sum % 2).ToString() + ans;
            carry = sum / 2;
        }
        if (carry != 0) ans = carry.ToString() + ans;
        return ans;
    }
}