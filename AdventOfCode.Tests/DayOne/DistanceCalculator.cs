namespace AdventOfCode.Tests.DayOne;

public static class DistanceCalculator
{
    
    public static int GetDistance(string testInput)
    {
        var (leftList, rightList) = GenerateLists(testInput);
            
        leftList.Sort();
        rightList.Sort();

        return leftList.Select((t, i) => Math.Abs(t - rightList[i])).Sum();
        
    }


    public static int CalculateSimilarity(string testInput)
    {
        var (leftList, rightList) = GenerateLists(testInput);

        var score = 0;
        
        leftList.ForEach(x=> score += rightList.Count(i=> i == x) * x);

        return score;

    }

    private static (List<int> leftList, List<int> rightList) GenerateLists(string testInput)
    {
        var leftList = new List<int>();
        var rightList = new List<int>();

        var numberPairs = testInput.Split("\n");
        foreach (var numberPair in numberPairs)
        {
            var numbers = numberPair.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            leftList.Add(int.Parse(numbers[0]));
            rightList.Add(int.Parse(numbers[1]));
        }
        
        return (leftList, rightList);
    }
}