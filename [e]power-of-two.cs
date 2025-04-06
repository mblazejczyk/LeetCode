//https://leetcode.com/problems/power-of-two/

public class Solution {
    public bool IsPowerOfTwo(int n) {
        //if(Math.Log(n, 2) % 1 == 0){ floating problems on large numbers :c
        if(n <= 0){
            return false;
        }
        if((n & (n-1)) == 0){
            return true;
        }else{
            return false;
        }
    }
}
