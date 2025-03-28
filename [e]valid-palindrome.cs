// https://leetcode.com/problems/valid-palindrome/description/

public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = "";
        
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                cleaned += char.ToLower(c);
            }
        }
        
        string reversed = new string(cleaned.Reverse().ToArray());
        
        return cleaned == reversed;
    }
}
