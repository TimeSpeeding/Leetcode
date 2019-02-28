public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int>();
        for(int i = 0; i <= rowIndex; i++)
        {
            row.Insert(0, 1);
            for (int j = 1; j < row.Count - 1; j++)
                row[j] = row[j] + row[j + 1];
        }
        return row;
    }
}