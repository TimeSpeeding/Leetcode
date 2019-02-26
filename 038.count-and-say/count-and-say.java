class Solution {
    public String countAndSay(int n) {
        String oldi = "1";
        String newi = "";
        for (int i = 1; i < n; i++)
        {
            char a = oldi.charAt(0);
            int num = 1;
            for (int j = 1; j < oldi.length(); j++)
            {
                if (a == oldi.charAt(j)) num++;
                else
                {
                    newi += Integer.toString(num);
                    newi += a;
                    a = oldi.charAt(j);
                    num = 1;
                }
            }
            newi += Integer.toString(num);
            newi += a;
            oldi = newi;
            newi = "";
        }
        return oldi;
    }
}