class Solution {
public:
    bool isAnagram(string s, string t) {
        if(s.length() != t.length())
        {
            return false;
        }

        int counts[32] = {0};
        for(int i = 0; i < s.length(); i++)
        {
            counts[s[i]-'a']++;
        }

        for(int j = 0; j < t.length(); j++)
        {
            counts[t[j]-'a']--;
        }

        for(int k = 0; k < 32; k++)
        {
            if(counts[k] != 0)
            {
                return false;
            }
        }
        return true;
    }
};
