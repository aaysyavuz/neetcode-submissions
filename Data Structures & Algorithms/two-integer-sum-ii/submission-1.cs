public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        int sum = 0;

        while (left < right) {
            sum = numbers[left] + numbers[right];

            if (sum < target) {
                left++;
            } else if (sum > target) {
                right--;
            } else {
                return new int[] { left + 1, right + 1 };
            }
        }

        return Array.Empty<int>();
    }
}
