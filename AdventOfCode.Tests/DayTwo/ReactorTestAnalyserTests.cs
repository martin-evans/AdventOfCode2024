namespace AdventOfCode.Tests.DayTwo;

public class ReactorTestAnalyserTests
{
    [Fact]
    public void AnalyzeTests()
    {

        var result = AnalyserReport.Calculate(TestInput.Example);
        
        Assert.Equal(2, result);

    }
}

public class TestInput
{
    public const string Example = "7 6 4 2 1\n1 2 7 8 9\n9 7 6 2 1\n1 3 2 4 5\n8 6 4 4 1\n1 3 6 7 9";
}