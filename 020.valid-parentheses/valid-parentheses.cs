public class Solution {
    public bool IsValid(string s) {
        Stack<char> a = new Stack<char>();
        foreach (char c in s)
        {
            switch(c)
            {
                case '(': 
                case '[': 
                case '{': a.Push(c); break;
                case ')': if (a.Count == 0 || a.Pop() != '(') return false; break;
                case ']': if (a.Count == 0 || a.Pop() != '[') return false; break;
                case '}': if (a.Count == 0 || a.Pop() != '{') return false; break;
            }
        }
        return (a.Count == 0);
    }
}