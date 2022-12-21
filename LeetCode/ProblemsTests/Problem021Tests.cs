using Problems._021._Merge_Two_Sorted_Lists;

namespace ProblemsTests;

[TestFixture]
public class Problem021Tests
{
    [Test]
    public void empty_node()
    {
        var node = new Problem021().MergeTwoLists(new ListNode(), new ListNode());

        var resultList = GetResultList(node);

        Assert.That(resultList, Is.EqualTo(new List<int>()));
    }

    [Test]
    public void example_1()
    {
        var inputList1 = GenerateNode(new List<int>() { 1, 2, 4 });
        var inputList2 = GenerateNode(new List<int>() { 1, 3, 4 });
        var node = new Problem021().MergeTwoLists(inputList1, inputList2);

        var resultList = GetResultList(node);

        Assert.That(resultList, Is.EqualTo(new List<int>() { 1, 1, 2, 3, 4, 4 }));
    }

    private ListNode? GenerateNode(List<int> ints)
    {
        if (ints.Count == 0)
        {
            return null;
        }

        var node = new ListNode();
        var lastNode = node;

        foreach (var i in ints)
        {
            lastNode.next = new ListNode(i, null);
            lastNode = lastNode.next;
        }

        return node;
    }

    private List<int> GetResultList(ListNode node)
    {
        var resultList = new List<int>();
        while (node != null)
        {
            var value = node.val;
            resultList.Add(value);
            node = node.next;
        }

        return resultList;
    }
}