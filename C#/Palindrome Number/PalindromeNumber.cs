public class Solution {
    public bool IsPalindrome (int x) {
        if (x < 0)
            return false;
        List<int> digits = new List<int> ();
        int duplix = x, iterT = 0;
        while (duplix > 0) {
            digits.Add (duplix % 10);
            duplix /= 10;
            iterT += 1;
        }
        int reversed = 0;
        for (int i = 0; i < iterT; i++) {
            reversed += digits[iterT - i - 1] * (int) Math.Pow (10, i);
        }
        if (reversed == x)
            return true;
        else
            return false;
    }
}