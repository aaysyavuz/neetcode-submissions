public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0, right = 0, maxFrequency = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int result = 0;

        while (right < s.Length) {
            if (!dict.ContainsKey(s[right])) {
                dict.Add(s[right], 1);
            } else {
                dict[s[right]] += 1;
            }

            maxFrequency = Math.Max(maxFrequency, dict[s[right]]);

            while (right - left + 1 - maxFrequency > k) {
                dict[s[left]] -= 1;
                left++;
            }

            right++;
            result = Math.Max(result, right - left);
        }

        return result;
    }
}
