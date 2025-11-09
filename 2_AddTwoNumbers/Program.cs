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
        return SumListNode(l1, l2);
    }
    
    public ListNode SumListNode(ListNode ln1, ListNode ln2, bool carry = false){
        int sum = Convert.ToInt32(carry);
        if (ln1 != null){
            sum += ln1.val;
        }
        if (ln2 != null){
            sum += ln2.val;
        }
        if (ln1 == null && ln2 == null && !carry){
            return null;
        }
        else{
            carry = false;
            if (sum > 9){
                carry = true;
                sum -= 10;
            }
            ListNode sumLn = new ListNode(sum);
            if (ln1 != null){
                ln1 = ln1.next;
            }
            if (ln2 != null){
                ln2 = ln2.next;
            }
            sumLn.next = SumListNode(ln1, ln2, carry);
            return sumLn;
        }
    }
}