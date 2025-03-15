// https://leetcode.com/problems/rotate-string/description/?envType=daily-question&envId=2025-03-15

public class Solution {
    public bool RotateString(string s, string goal) {
        for(int i = 1; i < s.Length + 1; i++){
            string temp = s.Remove(i);
            string cur = s.Remove(0, i);
            if(cur + temp == goal){
                return true;
            }
        }
        return false;
    }
}
