public class Solution {
    public string AddBinary (string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int num = 0, residual = 0;
        StringBuilder sb = new StringBuilder ();
        while (i >= 0 || j >= 0 || residual != 0) {
            // 由于char '1' 转换为int 是49不是1，所以需要减去 '0' 也就是48
            num = (i >= 0 ? (int) a[i] - '0' : 0) + (j >= 0 ? (int) b[j] - '0' : 0);
            if (residual != 0) {
                num += residual;
                residual = 0;
            }
            if (num >= 2) {
                num %= 2;
                residual = 1;
            }
            sb.Append (num);
            i--;
            j--;
        }
        char[] result = sb.ToString ().ToCharArray ();
        Array.Reverse (result);
        return new string (result);
    }

}