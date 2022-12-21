using Problems._021._Merge_Two_Sorted_Lists;

namespace ProblemsTests;

[TestFixture]
public class Problem021Tests
{
    [Test]
    public void empty_node()
    {
        var node = new Problem021().MergeTwoLists(new ListNode(), new ListNode());

        var resultList = new List<int>();
        while (node != null)
        {
            var value = node.val;
            resultList.Add(value);
            node = node.next;  
        }
   
        Assert.That(resultList, Is.EqualTo(new List<int>(){}));
    }
    
}