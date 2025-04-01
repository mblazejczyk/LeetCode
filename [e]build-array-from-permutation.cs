//https://leetcode.com/problems/build-array-from-permutation/

public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] solution = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            solution[i] = nums[nums[i]];
        }
        return solution;
    }
}
