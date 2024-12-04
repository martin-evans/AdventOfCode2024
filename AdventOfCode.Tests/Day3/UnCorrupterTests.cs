using Xunit.Abstractions;

namespace AdventOfCode.Tests.Day3;

public class UnCorrupterTests(ITestOutputHelper outputHelper)
{

    [Fact]
    public void ProofOfConcept()
    {
        var i = UnCorrupter.Calculate(TestInput.Example);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.Equal(161, i);

    }
    
    [Fact]
    public void ProofOfConcept2()
    {
        var i = UnCorrupter.Calculate2(TestInput.Example2);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.Equal(48, i);

    }
    
    [Fact]
    public void Scenario1()
    {
        var i = UnCorrupter.Calculate(TestInput.Input);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.True(i> 0);

    }
    
    [Fact]
    public void Scenario2()
    {
        var i = UnCorrupter.Calculate2(TestInput.Input);
        
        outputHelper.WriteLine(i.ToString());
        
        Assert.True(i> 0);

    }

    
}