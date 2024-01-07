using Problems._206._Reverse_Linked_List;
using Problems.Models;

namespace ProblemsTests;

[TestFixture]
public class Problem206Tests
{
    [Test]
    public void example_1()
    {
        var inputList = GenerateNode(new List<int> { 1, 2, 3, 4, 5 });
        var actual = new Problem206().ReverseList(inputList);
        var resultList = GetResultList(actual);
        Assert.That(resultList, Is.EqualTo(new List<int> { 5, 4, 3, 2, 1 }));
    }

    private ListNode? GenerateNode(List<int> ints)
    {
        if (ints.Count == 0) return null;

        var node = new ListNode();
        var lastNode = node;

        foreach (var i in ints)
        {
            lastNode.next = new ListNode(i);
            lastNode = lastNode.next;
        }

        return node.next;
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