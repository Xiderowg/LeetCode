public class Solution {
    public int CharToNumber (char c) {
        return (int) c - 64;
    }
    public int TitleToNumber (string s) {
        int n = s.Length, t = 0;
        for (int i = 0; i < n; i++) t += CharToNumber (s[i]) * (int) Math.Pow (26, n - i - 1);
        return t;
    }
}