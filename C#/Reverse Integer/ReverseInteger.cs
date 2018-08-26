public class Solution {
    public int Reverse (int x) {
        bool reverse = x < 0 ? true : false;
        string strX = reverse?(-x).ToString () : x.ToString ();
        int len = strX.Length;
        StringBuilder resultStr = new StringBuilder (reverse? "-": "");
        for (int i = 0; i < len; i++) {
            resultStr.Append (strX[len - i - 1]);
        }
        int result = 0;
        int.TryParse (resultStr.ToString (), out result);
        return result;
    }
}