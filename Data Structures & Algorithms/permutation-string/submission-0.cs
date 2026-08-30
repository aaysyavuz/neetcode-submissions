public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        Dictionary<char, int> s1Frequence = new Dictionary<char, int>();

        foreach (char c in s1) {
            if (!s1Frequence.ContainsKey(c)) {
                s1Frequence.Add(c, 1);
            } else {
                s1Frequence[c] += 1;
            }
        }

        int left = 0;
        int right = 0;
        Dictionary<char, int> windowFrequency = new Dictionary<char, int>();

        while (right < s2.Length) {
            if (!windowFrequency.ContainsKey(s2[right])) {
                windowFrequency.Add(s2[right], 1);
            } else {
                windowFrequency[s2[right]] += 1;
            }

            if (right - left + 1 == s1.Length) {
                bool isMatch = true;

                foreach (var s in s1Frequence) {
                    if (!windowFrequency.ContainsKey(s.Key) || windowFrequency[s.Key] != s.Value) {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) {
                    return true;
                } else {
                    windowFrequency[s2[left]] -= 1;
                    if (windowFrequency[s2[left]] == 0) {
                        windowFrequency.Remove(s2[left]);
                    }
                    left++;
                }
            }

            right++;
        }

        return false;
    }
}
