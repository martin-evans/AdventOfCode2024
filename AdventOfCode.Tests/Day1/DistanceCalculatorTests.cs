using Xunit.Abstractions;

namespace AdventOfCode.Tests.Day1;

public class DistanceCalculatorTests(ITestOutputHelper outputHelper)
{
    [Fact]
    public void GetDistanceReturnsExpectedValue()
    {
        var result = DistanceCalculator.GetDistance(TestInput.Example);
        
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void CalculateSimilarityReturnsExpectedValue()
    {
        var result = DistanceCalculator.CalculateSimilarity(TestInput.Example);
        
        Assert.Equal(31, result);
    }
    
    [Fact]
    public void StageOne()
    {
        var result = DistanceCalculator.GetDistance(TestInput.One);
        outputHelper.WriteLine("Distance - {0}", result);
    }
    
    [Fact]
    public void StageTwo()
    {
        var result = DistanceCalculator.CalculateSimilarity(TestInput.One);
        outputHelper.WriteLine("SimilarityScore - {0}", result);
    }
}