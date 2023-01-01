using Problems._121._Best_Time_to_Buy_and_Sell_Stock;

namespace ProblemsTests;

[TestFixture]
public class Problem121Tests
{
    [TestCase(new int[] {7, 1, 5, 3, 6, 4}, 5)]
    [TestCase(new int[] {7, 6, 4, 3, 1}, 0)]
    public void example_1(int[] prices, int expected)
    {
        var actual = new Problem121().MaxProfit(prices);
        Assert.That(actual, Is.EqualTo(expected));
    }
}