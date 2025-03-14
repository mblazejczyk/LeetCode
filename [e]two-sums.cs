// https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] s = [0, 0];
        bool f = false;

        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if((nums[i] + nums[j]) == target){
                    s[0] = i;
                    s[1] = j;
                    f = true;
                    break;
                }
            }
            if(f){
                break;
            }
        }

        return s;
    }
}
