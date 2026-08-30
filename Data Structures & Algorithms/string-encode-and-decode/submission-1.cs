public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < strs.Count(); i++) {
            sb.Append(strs[i].Length);
            sb.Append("#");
            sb.Append(strs[i]);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> l = new List<string>();

        int i = 0;

        while (i < s.Length) {
            int j = i;

            while (s[j] != '#') {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, length);

            l.Add(str);

            i = j + 1 + length;
        }

        return l;
    }
}
