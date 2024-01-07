using Problems._020._Valid_Parentheses;

namespace ProblemsTests;

[TestFixture]
public class Problem020Tests
{
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([)]", false)]
    public void example_1(string input, bool expected)
    {
        var actual = new Problem020().IsValid(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}