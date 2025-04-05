//https://leetcode.com/problems/majority-element/

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach(int i in nums){
            if(count.ContainsKey(i)){
                count[i]++;
            }else{
                count.Add(i, 1);
            }
        }
        return count.MaxBy(kvp => kvp.Value).Key;
    }
}
