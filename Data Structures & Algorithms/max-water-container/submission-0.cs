public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;

        int maxArea = 0;

        while (left < right) {
            maxArea = Math.Max(maxArea, Math.Min(heights[left], heights[right]) * (right - left));

            if (heights[left] < heights[right])
                left++;
            else {
                right--;
            }
        }

        return maxArea;
    }
}
