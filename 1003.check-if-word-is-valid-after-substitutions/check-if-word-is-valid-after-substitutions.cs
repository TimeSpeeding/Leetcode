public class Solution {
    public bool IsValid(string S) {
        int[] hash = new int[3] {0,0,0};
        int i = 0;
        for (i = 0; i < S.Length; i++)
        {
            hash[S[i] - 'a']++;
            if (hash[0] < hash[1] || hash[1] < hash[2]) return false;
        }
        if (hash[0] == hash[1] && hash[1] == hash[2]) return true;
        else return false;
    }
}