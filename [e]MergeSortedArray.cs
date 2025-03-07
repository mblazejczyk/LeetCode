// https://leetcode.com/problems/merge-sorted-array/description/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] n1 = nums1;
        int[] n2 = nums2;
        int j = 0;
        for(int i = m; i < m + n; i++){
            if(n1[i] == 0){
                n1[i] = n2[j];
                j++;
            }
        }
        Array.Sort(n1);
        Console.WriteLine(n1);
    }
}
