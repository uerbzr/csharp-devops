using workshop.calculator;

namespace workshop.tests;

public class Tests
{
    
    [Test]
    public void TestTwoPlusThreeEqualsFive()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }
}
