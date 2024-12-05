using Xunit.Abstractions;

namespace AdventOfCode.Tests.Day4;

public class WordSearchAnalyserTests(ITestOutputHelper outputHelper)
{
    [Theory]
    [InlineData(TestInput.Example)]
    [InlineData(TestInput.Example2)]
    public void AnalyseTestInputReturnsExpectedValue(string input)
    {
        var result = WordSearchAnalyser.Analyse(input);
        
        Assert.Equal(18,result);
    }
    
    [Theory]
    [InlineData(TestInput.Example)]
    public void X_Mas_AnalyseTestInputReturnsExpectedValue(string input)
    {
        var result = WordSearchAnalyser.Analyse(input, WordSearchAnalyser.RuleType.X_mas);
        
        Assert.Equal(9,result);
    }
    
    [Fact]
    public void ScenarioOne()
    {
        var result = WordSearchAnalyser.Analyse(TestInput.Input);
        
        outputHelper.WriteLine(result.ToString());
        
        Assert.True(result== 2344);
    }
    
    [Fact]
    public void ScenarioTwo()
    {
        var result = WordSearchAnalyser.Analyse(TestInput.Input, WordSearchAnalyser.RuleType.X_mas);
        
        outputHelper.WriteLine(result.ToString());
        
        Assert.True(result < 1840);
    }
}