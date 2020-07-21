public class Solution {
    public char NumToChar (int num) {
        return (char) (num + 64);
    }

    public string ConvertToTitle (int n) {
        Stack<char> stk = new Stack<char> ();
        int res = 0, nums = n;
        while (nums > 0) {
            res = nums % 26;
            nums = (nums - res) / 26;
            if (res == 0 && nums != 0) {
                res = 26;
                nums--;
            }
            if (res != 0) stk.Push (NumToChar (res));
            if (nums <= 26 && nums > 0) {
                stk.Push (NumToChar (nums));
                nums = 0;
            }
        }
        StringBuilder sb = new StringBuilder ();
        while (stk.Count > 0) sb.Append (stk.Pop ());
        return sb.ToString ();
    }
}