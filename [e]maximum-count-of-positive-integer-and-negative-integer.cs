// https://leetcode.com/problems/maximum-count-of-positive-integer-and-negative-integer/description/?envType=daily-question&envId=2025-03-16

public class Solution {
    public int MaximumCount(int[] nums) {
        int pos = 0;
        int neg = 0;

        foreach(int i in nums){
            if(i > 0){
                pos++;
            }else if(i < 0){
                neg++;
            }
        }
        return pos > neg ? pos : neg;
    }
}
