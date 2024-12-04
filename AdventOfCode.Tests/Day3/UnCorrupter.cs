using System.Text.RegularExpressions;

namespace AdventOfCode.Tests.Day3;

public static class UnCorrupter
{
    public static int Calculate(string input)
    {
        var pattern = new Regex(@"mul\((\d+),(\d+)\)");
        var matches = pattern.Matches(input);
        
        var delimiters = new[] { "mul(", ",", ")" };
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

    public static int Calculate2(string input)
    {
        var pattern = new Regex(@"mul\((\d+),(\d+)\)|don\'t\(\)|do\(\)");
        var delimiters = new[] { "mul(", ",", ")" };

        var matches = pattern.Matches(input);
        
        var res = 0;

        var filteredMatches = new List<string>();

        var include = true;
        
        foreach (Match match in matches)
        {
            include = match.Value switch
            {
                "don't()" => false,
                "do()" => true,
                _ => include
            };

            if (include && match.Value != "do()")
            {
                filteredMatches.Add(match.Value);
            }
            
        }

        filteredMatches.ForEach(x =>
        {
            var digits = x.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            res += digits[0] * digits[1];
        });
            

        return res;
    }
}