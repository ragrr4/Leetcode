// 5ms, 54.9 Mb
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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        Stack num1 = new();
        Stack num2 = new();

        while (l1 != null || l2 != null)
        {
            if (l1 != null)
            {
                num1.Push(l1.val);
                l1 = l1.next;
            }
            if (l2 != null)
            {
                num2.Push(l2.val);
                l2 = l2.next;
            }
        }
        //Calculate Result
        int sum = 0;
        bool carry = false;
        ListNode result = null;
        while ((num1.Count + num2.Count) != 0)
        {
            if (carry)
            {
                sum = 1;
                carry = false;
            }
            if (num1.Count != 0)
            {
                sum += (int)num1.Pop();
            }
            if (num2.Count != 0)
            {
                sum += (int)num2.Pop();
            }
            if (sum > 9)
            {
                carry = true;
                sum -= 10;
            }
            result = new(sum, result);
            sum = 0;
        }
        if (carry)
        {
            result = new(1, result);
        }
        return result;
    }
}