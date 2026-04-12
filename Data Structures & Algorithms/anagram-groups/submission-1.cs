public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var stringArray = strs[i].ToCharArray();
            Array.Sort(stringArray);
            var sortedString = new string(stringArray);
            if (map.ContainsKey(sortedString))
            {
                map[sortedString].Add(strs[i]);
            }
            else
            {
                map.Add(sortedString, new List<string>() { strs[i] });
            }
        }

        return map.Values.ToList();
    }
}
