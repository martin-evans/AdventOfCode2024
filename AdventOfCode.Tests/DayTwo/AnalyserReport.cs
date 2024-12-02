namespace AdventOfCode.Tests.DayTwo;

public static class AnalyserReport
{
    public static int Calculate(string data)
    {
        var ret = data.Split("\n")
            .Select(row => row.Split(" ").Select(int.Parse).ToArray())
            .Where(rowData => IsSameDirection(rowData) && IncrementsAreSafe(rowData));


        return ret.Count();
    }

    private static bool IncrementsAreSafe(int[] data)
    {
        var lst = new List<int>();

        for (var i = 0; i < data.Length - 1; i++)
        {
            lst.Add(data[i] - data[i + 1]);
        }

        return lst.TrueForAll(diff => diff is <= 3 and >= -3 and not 0);
    }


    private static bool IsSameDirection(int[] data)
    {
        var lst = new List<int>();

        for (var i = 0; i < data.Length - 1; i++)
        {
            lst.Add(data[i] - data[i + 1]);
        }

        return lst.TrueForAll(d => d > 0) || lst.TrueForAll(d => d < 0);
    }
}