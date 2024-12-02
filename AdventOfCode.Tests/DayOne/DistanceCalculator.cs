namespace AdventOfCode.Tests.DayOne;

public class DistanceCalculator
{
    public static int GetDistance(string testInput)
    {
        var lst1 = new List<int>();
        var lst2 = new List<int>();

        var numberPairs = testInput.Split("\n");
        foreach (var numberPair in numberPairs)
        {
            var numbers = numberPair.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            lst1.Add(int.Parse(numbers[0]));
            lst2.Add(int.Parse(numbers[1]));
        }
        
        lst1.Sort();
        lst2.Sort();

        return lst1.Select((t, i) => Math.Abs(t - lst2[i])).Sum();
        
    }
    
    
    
    
}