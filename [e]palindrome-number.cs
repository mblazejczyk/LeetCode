// https://leetcode.com/problems/palindrome-number/

public class Solution {
    public bool IsPalindrome(int x) {
        string xs = x.ToString();
        for(int i = 0; i < (int)(xs.Length/2); i++){
            if(xs[i] != xs[xs.Length - i - 1]){
                return false;
            }
        }
        return true;
    }
}
