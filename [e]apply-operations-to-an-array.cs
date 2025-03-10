// https://leetcode.com/problems/apply-operations-to-an-array/?envType=daily-question&envId=2025-03-10

public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int[] operation = nums;
        for(int i = 0; i < operation.Length - 1; i++){
            if(operation[i] == operation[i+1]){
                operation[i] *= 2;
                operation[i+1] = 0;
            }
        }

        int[] ans = new int[nums.Length];
        int j = 0;
        for(int i = 0; i < operation.Length; i++){
            if(operation[i] != 0){
                ans[j] = operation[i];
                j++;
            }
        }
        for(int i = j; i < ans.Length; i++){
            ans[j] = 0;
        }
        return ans;
    }
}
