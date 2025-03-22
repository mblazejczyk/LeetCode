// https://leetcode.com/problems/special-array-i/description/?envType=daily-question&envId=2025-03-22

public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if(nums.Length  == 1){
            return true;
        }

        for(int i = 0; i <= nums.Length - 2; i++){
            if(nums[i] % 2 == 0 && nums[i+1] % 2 != 0){
                continue;
            }
            if(nums[i] % 2 != 0 && nums[i+1] % 2 == 0){
                continue;
            }
            return false;
        }
        return true;
    }
}
