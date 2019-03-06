public class Solution {
    public string CountAndSay(int n) {
        string oldi = "1";
        string newi = "";
        for (int i = 1; i < n; i++)
        {
            char a = oldi[0];
            int num = 1;
            for (int j = 1; j < oldi.Length; j++)
            {
                if (a == oldi[j]) num++;
                else
                {
                    newi += num.ToString();
                    newi += a;
                    a = oldi[j];
                    num = 1;
                }
            }
            newi += num.ToString();
            newi += a.ToString();
            oldi = newi;
            newi = "";
        }
        return oldi;
    }
}