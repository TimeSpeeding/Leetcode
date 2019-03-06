public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> ptriangle = new List<IList<int>>();
        IList<int> row = new List<int>();
        for (int i = 0; i < numRows; i++)
        {
            row.Insert(0, 1);
            for (int j = 1; j < row.Count() - 1; j++)
                row[j] = row[j] + row[j + 1];
            ptriangle.Add(new List<int>(row));
        }
        return ptriangle;
    }
}