//https://leetcode.com/problems/roman-to-integer/

public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        Dictionary<char, int> romanValue = new Dictionary<char, int>();
        romanValue.Add('I', 1);
        romanValue.Add('V', 5);
        romanValue.Add('X', 10);
        romanValue.Add('L', 50);
        romanValue.Add('C', 100);
        romanValue.Add('D', 500);
        romanValue.Add('M', 1000);

        for(int i = 0; i < s.Length; i++){
            if(s.Length > i + 1 && romanValue[s[i]] < romanValue[s[i+1]]){
                sum += romanValue[s[i+1]] - romanValue[s[i]];
                i++;
            }else{
                sum += romanValue[s[i]];
            }
        }
        return sum;
    }
}
