public class Solution {
    public IList<string> CommonChars(string[] A) {
        int[] hash = new int[26] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        int[] newhash = new int[26] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        int i = 0, j = 0;
        for (i = 0; i < A[0].Length; i++)
        {
            hash[A[0][i] - 'a']++;
        }
        for (i = 1; i < A.Length; i++)
        {
            for (j = 0; j < A[i].Length; j++)
            {
                int temp = A[i][j] - 'a';
                if (hash[temp] != 0)
                {
                    newhash[temp]++;
                    hash[temp]--;
                }
            }
            for (j = 0; j < 26; j++)
            {
                hash[j] = newhash[j];
                newhash[j] = 0;
            }
        }
        IList<string> ans = new List<string>();
        i = 0;
        while (i < 26)
        {
            while (hash[i] != 0)
            {
                ans.Add(((char)(i + 'a')).ToString());
                hash[i]--;
            }
            i++;
        }
        return ans;
    }
}