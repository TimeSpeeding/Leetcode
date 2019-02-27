class Solution {
    public String addBinary(String a, String b) {
        String ans = "";
        int i = a.length() - 1, j = b.length() - 1, carry = 0;
        while (i >= 0 || j >= 0)
        {
            int sum = carry;
            if (j >= 0) sum += b.charAt(j--) - '0';
            if (i >= 0) sum += a.charAt(i--) - '0';
            ans = Integer.toString(sum % 2) + ans;
            carry = sum / 2;
        }
        if (carry != 0) ans = Integer.toString(carry) + ans;
        return ans;
    }
}