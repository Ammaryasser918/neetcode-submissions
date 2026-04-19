class Solution {
public:

    string encode(vector<string>& strs) {
    string ans;
    for (int i = 0; i < strs.size(); i++) {
        ans += to_string(strs[i].size()) + "#" + strs[i];
    }
    return ans;

}

vector<string> decode(string s) {

    vector<string> ans;
    int i = 0, j = 0;

    while (j < s.size()) {
        j = i;
        while (s[j] != '#') {
            j++;
        }
        int tmp = stoi(s.substr(i, j - i));
        i = j + 1;
        j = i + tmp;
        ans.push_back(s.substr(i, tmp));
        i = j;

    }
    return ans;

}
};
