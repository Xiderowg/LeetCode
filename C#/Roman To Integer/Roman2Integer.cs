public class Solution {
    public static Dictionary<char, int> Dict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
    public int RomanToInt (string s) {
        int result = 0, c = Dict[s[0]], cn = 0, len = s.Length;
        if (len == 1)
            return c;
        for (int i = 1; i < s.Length; i++) {
            cn = Dict[s[i]];
            if (cn > c) result -= c;
            else result += c;
            c = cn;
        }
        result += cn;
        return result;
    }
}