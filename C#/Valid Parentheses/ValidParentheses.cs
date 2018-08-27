public class Solution {
    public bool IsValid (string s) {
        if (s.Length % 2 != 0)
            return false;
        char c;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            c = s[i];
            if (c == '(')
                stack.Push (')');
            else if (c == '{')
                stack.Push ('}');
            else if (c == '[')
                stack.Push (']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
        return stack.Count == 0;
    }
}