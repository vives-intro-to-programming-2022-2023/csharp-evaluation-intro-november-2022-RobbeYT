using LabradorGoesWoof;

namespace Tests;

public class UnitTestBarkCounter
{
    private BarkCounter counter = new BarkCounter();

    [Fact]
    public void TestBarkCounter()
    {
        Assert.Equal(0, counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"));
        Assert.Equal(29, counter.CountBarks("xBxBBxxBBxxBxxxBBBBxBxxxxBxxxBBBBxxBBBxxBxBBxxBxBBBBxxxBxxBx"));
        Assert.Equal(27, counter.CountBarks("BxxBBBxBxxBBxxBBxBxxBBBxBBxxBxBxxxxBBxxxxxBBxxBBxBBxxxxxBxBx"));
        Assert.Equal(36, counter.CountBarks("BBBBxBxBxxxxBxxBBBBBBxxBxBBBBxBBxBBBBxxxxBBxBBBBxBxxxBBBBBxx"));
        Assert.Equal(22, counter.CountBarks("xxBxxxBxxxxxBxxxxxxBBxxxxBxxxBBxxBBxxxxBxxBBxBBBxBBxxBBxBxxB"));
        Assert.Equal(11, counter.CountBarks("xxxxxxxxxxxxxxxxBBxBBBBBBxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxBBB"));
        Assert.Equal(15, counter.CountBarks("xBxxxxxBBxxxBBxBBxBxBBxxxxxxxxxxxxxxxxxxxxxxxxxxBBBBxxxxxxxB"));
        Assert.Equal(32, counter.CountBarks("xBBBBBxxxBxBBxxBBBxBxxBxBxBxxxxBBxxBBxBxxBBxBBBxxxBBBBxBxBBx"));
        Assert.Equal(2, counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxBxxxxBxxxxxxxxxxxxxxxxx"));
        Assert.Equal(16, counter.CountBarks("BxxBxxxxxxxxBBBxxBBBxBBBxxBBxxxxxxxxxBBxxxxxxxxxxxxxxxxxBxxx"));
        Assert.Equal(60, counter.CountBarks("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"));
    }

    [Fact]
    public void TestInvalidFormat()
    {
        Assert.Equal(-1, counter.CountBarks(""));
        Assert.Equal(-1, counter.CountBarks("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"));
        Assert.Equal(-1, counter.CountBarks("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"));
        Assert.Equal(-1, counter.CountBarks("BxxBxxxxxxxxBBBxxBBBxBBBxxBBxxxxxxxxxBBxxxxxxxxxxxxxxxxBxxx"));
        Assert.Equal(-1, counter.CountBarks("BxxBxxxxxxxxBBBxxBBBxBBBxxBBxxxxxxxxxBBxxxxxxxxxxxxxxxxxBxxxx"));
    }
}