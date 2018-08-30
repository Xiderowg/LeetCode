public class Solution {
    public int[] PlusOne (int[] digits) {
        int len = digits.Length;
        if (digits[len - 1] != 9) {
            digits[len - 1] += 1;
            return digits;
        } else {
            digits[len - 1] = 0;
            for (int i = len - 2; i >= 0; i--) {
                if (1 + digits[i] >= 10) {
                    digits[i] = 0;
                } else {
                    digits[i] += 1;
                    return digits;
                }
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}