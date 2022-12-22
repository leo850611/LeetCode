namespace Problems._021._Merge_Two_Sorted_Lists
{
    public class Problem021
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var list1LastNode = list1;
            var list2LastNode = list2;
            while (list1LastNode != null)
            {
                if (list2LastNode != null && list1LastNode.val <= list2LastNode.val)
                {
                    var temp1 = list1LastNode.next;
                    var temp2 = list2LastNode.next;

                    list2LastNode.next = list1LastNode.next;
                    list1LastNode.next = list2LastNode;


                    if (temp1 == null)
                    {
                        list1LastNode.next = list2LastNode;
                        list2LastNode = null;
                    }
                    else
                    {
                        list1LastNode = temp1;
                        list2LastNode = temp2;
                    }
                }
                else if (list2LastNode == null)
                {
                    list1LastNode = list1LastNode.next;
                }
            }


            
            return list1;
        }
    }

    // Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

}