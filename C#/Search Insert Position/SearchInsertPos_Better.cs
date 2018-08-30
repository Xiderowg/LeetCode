public class Solution {
    public int SearchInsert (int[] nums, int target) {
        if (nums.Length == 0 || target < nums[0])
            return 0;
        if (target > nums[nums.Length - 1])
            return nums.Length;
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        while (left <= right) {
            mid = (left + right) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return left;
    }
}