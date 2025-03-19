// https://leetcode.com/problems/circular-sentence/description/?envType=daily-question&envId=2025-03-18

public class Solution {
    public bool IsCircularSentence(string sentence) {
        string[] splitted = sentence.Split(' ');

        if(splitted.Length == 1){
            if(splitted[0][0] != splitted[0][splitted[0].Length - 1]){
                return false;
            }
        }

        for(int i = 1; i < splitted.Length; i++){
            if(splitted[i-1][splitted[i-1].Length - 1] != splitted[i][0]){
                return false;
            }
        }

        if(splitted[0][0] != splitted[splitted.Length - 1][splitted[splitted.Length-1].Length - 1]){
            return false;
        }
        return true;
    }
}
