//https://leetcode.com/problems/add-digits/

public class Solution {
    public int AddDigits(int num) {
        string s = num.ToString();
        while(s.Length > 1){
            int tmp = 0;
            foreach(char c in s){
                tmp += c - '0';
            }
            s = tmp.ToString();
        }
        return Int32.Parse(s);
    }
}
