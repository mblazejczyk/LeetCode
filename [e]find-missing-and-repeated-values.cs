// https://leetcode.com/problems/find-missing-and-repeated-values/description/?envType=daily-question&envId=2025-03-13

public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        Dictionary<int, int> inl = new Dictionary<int, int>();
        for(int i = 1; i <= grid[0].Length * grid[0].Length; i++){
            inl.Add(i, 0);
        }

        for(int i = 0; i < grid[0].Length; i++){
            for(int j = 0; j < grid[0].Length; j++){
                inl[grid[i][j]]++;
            }
        }

        int[] res = new int[2];
        foreach(var i in inl){
            if(i.Value == 0){
                res[1] = i.Key;
            }else if(i.Value == 2){
                res[0] = i.Key;
            }
        }
        return res;
    }
}
