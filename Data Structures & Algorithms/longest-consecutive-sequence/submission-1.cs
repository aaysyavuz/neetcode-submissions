public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);
        int currentNumber = 0;
        int currentLength = 0;
        int longestLength = 0;

        foreach (var h in hs) {
            if (!hs.Contains(h - 1)) {
                currentNumber = h;
                currentLength = 1;

                while (hs.Contains(currentNumber + 1)) {
                    currentNumber += 1;
                    currentLength += 1;
                }

                longestLength = Math.Max(longestLength, currentLength);
            }
        }

        return longestLength;
    }
}
