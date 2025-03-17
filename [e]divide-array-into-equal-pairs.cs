// https://leetcode.com/problems/divide-array-into-equal-pairs/description/?envType=daily-question&envId=2025-03-17

public class Solution {
    public bool DivideArray(int[] nums) {
        bool devidable = true;
        if(nums.Length % 2 != 0){
            return false;
        }

        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach(int i in nums){
            if(count.ContainsKey(i)){
                count[i]++;
            }else{
                count.Add(i, 1);
            }
        }
        foreach(var i in count){
            if(i.Value % 2 != 0){
                devidable = false;
                break;
            }
        }
        return devidable;
    }
}
