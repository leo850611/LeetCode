namespace Problems._021._Merge_Two_Sorted_Lists
{
    public class Problem021
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var listNode = new ListNode();
            var listNodeTemp = listNode;
            while (list1 != null || list2 !=null)
            {
                if (list1 == null)
                {
                    listNodeTemp.next = list2;
                    list2 = list2.next; 
                    
                }
                else if (list2 == null)
                {
                    listNodeTemp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val <= list2.val)
                    {
                        listNodeTemp.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        listNodeTemp.next = list2;
                        list2 = list2.next;
                    }
                }
                
                
                listNodeTemp = listNodeTemp.next;
            }

            return listNode.next;
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