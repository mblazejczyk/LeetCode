// https://leetcode.com/problems/length-of-last-word/description/

public class Solution {
    public int LengthOfLastWord(string s) {
        string[] otp = s.Trim().Split(' ');
        return otp[otp.Length - 1].Length;
    }
}
