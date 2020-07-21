public class Solution {
    public int[] TwoSum (int[] numbers, int target) {
        int lo = 0, hi = numbers.Length - 1;
        while (numbers[lo] + numbers[hi] != target) {
            if (numbers[lo] + numbers[hi] < target) lo++;
            else hi--;
        }
        return new int[2] { lo + 1, hi + 1 };
    }
}