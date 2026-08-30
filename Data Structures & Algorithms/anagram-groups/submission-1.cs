public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string s in strs){
            var charArr = s.ToCharArray();
            Array.Sort(charArr);
            var key = new string(charArr);

            if(!dict.ContainsKey(key)){
                dict.Add(key, new List<string>());
            }

            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
