// https://leetcode.com/problems/add-two-numbers/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string l1in = "";
        ListNode check = l1;
        while(true){
            l1in = check.val + l1in;
            if(check.next == null){
                break;
            }else{
                check = check.next;
            }
        }

        string l2in = "";
        ListNode check2 = l2;
        while(true){
            l2in = check2.val + l2in;
            if(check2.next == null){
                break;
            }else{
                check2 = check2.next;
            }
        }

        ListNode final = null;
        int control = 0;
        int carry = 0;
        while (control < l1in.Length || control < l2in.Length || carry > 0) {
            int i1 = (control < l1in.Length) ? l1in[l1in.Length - 1 - control] - '0' : 0;
            int i2 = (control < l2in.Length) ? l2in[l2in.Length - 1 - control] - '0' : 0;

            int sum = i1 + i2 + carry;
            carry = sum / 10;
            final = new ListNode(sum % 10, final);

            control++;
        }

        ListNode check3 = final;
        string fs1 = "";
        while(true){
            fs1 = check3.val + fs1;
            if(check3.next == null){
                break;
            }else{
                check3 = check3.next;
            }
        }
        ListNode revFinal = new ListNode(fs1[fs1.Length-1] - '0', null);
        for(int i = fs1.Length-2; i >= 0; i--){
            revFinal = new ListNode(fs1[i]-'0', revFinal);
        }

        return revFinal;
    }
}
