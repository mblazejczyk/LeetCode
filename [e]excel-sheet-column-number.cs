//https://leetcode.com/problems/excel-sheet-column-number/

public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum = 0;
        int i = columnTitle.Length-1;
        foreach(char c in columnTitle){
            int t = (int)c-64;
            sum += (int)(t*(Math.Pow(26, i)));
            i--;
        }
        return sum;
    }
}
