namespace Tests;
using RateMySetup;

public class UnitTestRatingGenerator
{
    private RatingGenerator generator = new RatingGenerator();

    [Fact]
    public void TestBasic5StarRating()
    {
        Assert.Equal("<_____>", generator.Rate(0, 5, '*'));
        Assert.Equal("<*____>", generator.Rate(1, 5, '*'));
        Assert.Equal("<**___>", generator.Rate(2, 5, '*'));
        Assert.Equal("<***__>", generator.Rate(3, 5, '*'));
        Assert.Equal("<****_>", generator.Rate(4, 5, '*'));
        Assert.Equal("<*****>", generator.Rate(5, 5, '*'));
    }

    [Fact]
    public void TestRatingSize()
    {
        Assert.Equal("<___>", generator.Rate(0, 3, '*'));
        Assert.Equal("<*****_____>", generator.Rate(5, 10, '*'));
        Assert.Equal("<**********__>", generator.Rate(10, 12, '*'));
    }

    [Fact]
    public void TestRatingSymbol()
    {
        Assert.Equal("<___>", generator.Rate(0, 3, '@'));
        Assert.Equal("<@__>", generator.Rate(1, 3, '@'));
        Assert.Equal("<$$_>", generator.Rate(2, 3, '$'));
    }

    [Fact]
    public void TestAbnormalSizes()
    {
        Assert.Equal("<>", generator.Rate(0, 0, '*'));
        Assert.Equal("<>", generator.Rate(5, 2, '*'));
        Assert.Equal("<>", generator.Rate(12, 0, '*'));
    }
}