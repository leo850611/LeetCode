using Problems.Models;

namespace Problems._206._Reverse_Linked_List
{
    // https://leetcode.com/problems/reverse-linked-list/description/
    public class Problem206
    {
        private ListNode _temp = null;
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
                
            var headNext = head.next;
            head.next = _temp;
            _temp = head;
                
            if (headNext == null)
            {
                return head;
            }
                
            return ReverseList(headNext);
        }
    }
}