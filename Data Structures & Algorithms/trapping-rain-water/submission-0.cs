public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1, leftMax = 0, rightMax = 0, totalWater = 0;

        while (left < right) {
            leftMax = Math.Max(leftMax, height[left]);
            rightMax = Math.Max(rightMax, height[right]);

            if (leftMax < rightMax) {
                totalWater += leftMax - height[left];
                left++;
            } else {
                totalWater += rightMax - height[right];
                right--;
            }
        }

        return totalWater;
    }
}
