//https://leetcode.com/problems/richest-customer-wealth/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int wealthiest = 0;
        foreach(int[] i in accounts){
            int sum = 0;
            foreach(int j in i){
                sum += j;
            }
            if(sum > wealthiest){
                wealthiest = sum;
            }
        }
        return wealthiest;
    }
}
