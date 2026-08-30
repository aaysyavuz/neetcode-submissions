public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var right = new int[nums.Length];
        var left = new int[nums.Length];

        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            if (i == 0) {
                left[i] = 1;
                continue;
            }

            left[i] = left[i - 1] * nums[i - 1];
        }

        for (int i = nums.Length - 1; i >= 0; i--) {
            if (i == nums.Length - 1) {
                right[nums.Length - 1] = 1;
            } else {
                right[i] = right[i + 1] * nums[i + 1];
            }
            result[i] = right[i] * left[i];
        }

        return result;
    }
}
