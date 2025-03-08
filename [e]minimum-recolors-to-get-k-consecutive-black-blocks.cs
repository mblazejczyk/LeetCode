//https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/?envType=daily-question&envId=2025-03-08

public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int minimum = k;

        for(int i = 0; i <= blocks.Length - k; i++){
            int current = 0;
            for(int j = i; j < i + k; j++){
                if(blocks[j] == 'W'){
                    current++;
                }
            }
            if(current < minimum){
                minimum = current;
            }
        }
        return minimum;
    }
}
