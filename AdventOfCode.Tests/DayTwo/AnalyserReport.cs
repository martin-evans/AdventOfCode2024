using System.Runtime.CompilerServices;

namespace AdventOfCode.Tests.DayTwo;

public class AnalyserReport
{
    public static int Calculate(string data)
    {
        var result = 0;
        
        foreach (var row in data.Split("\n"))
        {
            
            var rowData = row.Split(" ").Select(int.Parse).ToArray();

            if (IsSameDirection(rowData) && IncrementsAreSafe(rowData))
            {
                result++;
            }
            
        }


        return result;
    }

    private static bool IncrementsAreSafe(int[] data)
    {
        
        var lst = new List<int>();

        for (int i = 0; i < data.Length-2; i++)
        {
            lst.Add(data[i] - data[i + 1]);
        }
        
        //var diffs = data.Select((t, i) => data[i + 1] - t).ToList();
        
        return lst.ToArray().All(diff => diff is <= 2 and >= -2);
        
    }


    private static bool IsSameDirection(int[] data)
    {

        var lst = new List<int>();

        for (int i = 0; i < data.Length-2; i++)
        {
            lst.Add(data[i] - data[i + 1]);
        }


        var diffs = lst.ToArray(); //data.Select((t, i) => data[i + 1] - t).ToList();
        

        
        return diffs.All(diff => diff > 0) || diffs.All(diff => diff < 0);
        
    }
    
}