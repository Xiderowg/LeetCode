public class Solution {
    public bool IsIsomorphic (string s, string t) {
        if (s.Length <= 1) return true;
        Dictionary<char, char> table = new Dictionary<char, char> ();
        for (int i = 0; i < s.Length; i++) {
            if (table.Keys.Contains (s[i])) {
                if (table[s[i]] != t[i]) return false;
            } else {
                if (table.Values.Contains (t[i])) return false;
                table.Add (s[i], t[i]);
            }
        }
        return true;
    }
}