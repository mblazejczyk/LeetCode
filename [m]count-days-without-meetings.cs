// https://leetcode.com/problems/count-days-without-meetings/description/?envType=daily-question&envId=2025-03-24

//overall problem is easy however looking at time and memory, it got hard. Used a tip for this one. Look at submition history on my LeetCode for thinking process

public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings, (a, b) => a[0] - b[0]);
        long busyDays = 0;
        int start = -1;
        int end = -1;

        foreach (var meeting in meetings) {
            int currStart = meeting[0];
            int currEnd = meeting[1];

            if (currStart > end) {
                busyDays += (end - start + 1);
                start = currStart;
                end = currEnd;
            } else {
                end = Math.Max(end, currEnd);
            }
        }

        busyDays += (end - start);

        return (int)(days - busyDays);
    }
}
