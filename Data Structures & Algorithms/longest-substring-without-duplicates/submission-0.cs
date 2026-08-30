public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int result = 0;
        HashSet<char> hs = new HashSet<char>();

        while (right < s.Length) {
            if (!hs.Add(s[right])) {
                hs.Remove(s[left]);
                left++;
            } else {
                right++;
            }

            result = Math.Max(result, right - left);
        }

        return result;
    }
}
