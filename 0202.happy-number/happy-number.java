class Solution {
    public boolean isHappy(int n) {
        int slow = n, fast = n;
        do{
            slow = cal(slow);
            fast = cal(cal(fast));
        } while (slow != fast);
        if (slow == 1) return true;
        return false;
    }
    public int cal(int n) {
        int sum = 0;
        while(n > 0)
        {
            sum += (n % 10) * (n % 10);
            n /= 10;
        }
        return sum;
    }
}