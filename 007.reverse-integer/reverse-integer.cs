public class Solution {
    public int Reverse(int x) {
            int y = 0;
            while (x != 0)
            {
                int temp = x % 10;
                x /= 10;
                if (y > int.MaxValue / 10 || (y == int.MaxValue / 10 && temp > 7)) return 0;
                if (y < int.MinValue / 10 || (y == int.MinValue / 10 && temp < -8)) return 0;
                y = y * 10 + temp;
            }
            return y;
    }
}