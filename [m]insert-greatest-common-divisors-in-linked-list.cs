// https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/description/

public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        List<int> newar = new List<int>();

        ListNode next = head;
        while(true){
            if(next.next == null){
                newar.Add(next.val);
                break;
            }

            int lastdivision = 0;
            int curr = 0;
            if(next.val > next.next.val){
                lastdivision = next.next.val;
                curr = next.val;
            }else{
                lastdivision = next.val;
                curr = next.next.val;
            }

            while (curr != 0) {
                int temp = curr;
                curr = lastdivision % curr;
                lastdivision = temp;
            }
            
            newar.Add(next.val);
            newar.Add(lastdivision);
            next = next.next;
        }

        ListNode res = new ListNode(newar[newar.Count-1], null);
        for(int i = newar.Count - 2; i >= 0; i--){
            res = new ListNode(newar[i], res);
        }
        return res;
    }
}
