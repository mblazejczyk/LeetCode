// https://leetcode.com/problems/score-of-a-string/

public class Solution {
    public int ScoreOfString(string s) {
        int final = 0;
        for(int i = 0; i < s.Length - 1; i++){
            final += Math.Abs((int)s[i] - (int)s[i+1]);
        }
        return final;
    }
}
