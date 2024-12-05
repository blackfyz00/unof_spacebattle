namespace SpaceBattle.Tests;
using SpaceBattle.Lib;
using Moq;

public class AngleTest
{
    [Fact]
    public void TestSameAnglesAreEqual()
    {
        var angl1 = new Angle(12);
        var angl2 = new Angle(12);
        Assert.NotSame(angl1, angl2);
        Assert.Equal(angl1, angl2);
    }

    [Fact]
    public void TestComparingAngleWithNotAngleType()
    {
        Angle angl1 = new Angle(12);
        bool Equality = angl1.Equals(12);
        Assert.False(Equality);
    }

    [Fact]
    public void TestSameAnglesAreNotEqual()
    {
        var angl1 = new Angle(10);
        var angl2 = new Angle(12);
        Assert.NotEqual(angl1, angl2);
    }

    [Fact]
    public void TestSummationPositive()
    {
        var angl1 = new Angle(10);
        var angl2 = new Angle(12);
        var angl3 = angl1 + angl2;
        Assert.Equal(angl3, new Angle(22));
    }

    [Fact]
    public void TestSummationNegative()
    {
        var angl1 = new Angle(10);
        var angl2 = new Angle(-30);
        var angl3 = angl1 + angl2;
        Assert.Equal(angl3, new Angle(-20));

    }
}