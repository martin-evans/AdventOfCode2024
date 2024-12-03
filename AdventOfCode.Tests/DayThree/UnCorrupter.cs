using System.Text.RegularExpressions;

namespace AdventOfCode.Tests.DayThree;

public static class UnCorrupter
{
    public static int Calculate(string input)
    {
        
        var pattern = new Regex(@"mul\((\d+),(\d+)\)");
        var delimiters = new[] { "mul(", ",", ")" };

        var matches = pattern.Matches(input);
        
        var res = 0;
        
        
        foreach (Match match in matches)
        {
            var digits = match.Value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            res += digits[0] * digits[1];
        }

        return res;
        
    }
}