using Problems._001._Two_Sum;

namespace ProblemsTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void example_1()
    {
        var result = new Problem001().TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
    }

    [Test]
    public void example_2()
    {
        var result = new Problem001().TwoSum(new[] { 3, 2, 4 }, 6);
        Assert.That(result, Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void example_3()
    {
        var result = new Problem001().TwoSum(new[] {3, 3} , 6);
        Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
    }
}