namespace AdventOfCode.Tests.Day4;

public static class WordSearchAnalyser
{
    public enum RuleType
    {
        Xmas,
        X_mas
    }
    
    public static int Analyse(string input, RuleType ruleType = RuleType.Xmas)
    {
        var res = 0;
        // break into a board
        
        var lines = input.Split(["\n"], StringSplitOptions.RemoveEmptyEntries);
        
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            
            for(var l = 0; l < line.Length; l++)
            {
                var letter = line[l];
                
                if(ruleType == RuleType.Xmas && letter == 'X')
                {
                    res += CheckForXmas(grid:lines, x:l, y:i); 
                }
                else if(ruleType == RuleType.X_mas && letter == 'A')
                {
                    res += CheckForX_mas(grid:lines, x:l, y:i); 
                }
            }
        }
        
        return res;

    }

    private static int CheckForX_mas(string[] grid, int x, int y)
    {
        var lineLength = grid[0].Length;
        var res = 0;
        
        if (!RoomAvailable(x, y)) return res;
        
        if ((grid[y-1][x-1] == 'M' && grid[y+1][x-1] == 'M' 
                                  && grid[y-1][x+1] == 'S' && grid[y+1][x+1] == 'S')||
            (grid[y-1][x-1] == 'S' && grid[y+1][x-1] == 'S' 
                                   && grid[y-1][x+1] == 'M' && grid[y+1][x+1] == 'M') ||
            (grid[y-1][x-1] == 'S' && grid[y+1][x-1] == 'M' 
                                   && grid[y-1][x+1] == 'S' && grid[y+1][x+1] == 'M') ||
            (grid[y-1][x-1] == 'M' && grid[y+1][x-1] == 'S' 
                                   && grid[y-1][x+1] == 'M' && grid[y+1][x+1] == 'S'))
        {
            Increment();
        }
        


        return res;

        bool RoomAvailable(int x1, int y1) => y1 - 1 >= 0 && y1 + 1 < grid.Length && x1 - 1 >= 0 && x1 + 1 < lineLength;

        void Increment() => res += 1;
    }

    private static int CheckForXmas(string[] grid, int x, int y)
    {
        var wordLength = 4;
        var wordLengthDiag = wordLength - 1;
        var lineLength = grid[0].Length;

        int res = 0;

        void increment() => res += 1;


        // forwards
        if (x + wordLength <= lineLength)
        {
            if (grid[y][x+1] == 'M' && grid[y][x+2] == 'A' && grid[y][x+3] == 'S')
            {
                increment();
            }
        }
        
        // backwards
        if (x - wordLength >= 0)
        {
            if (grid[y][x-1] == 'M' && grid[y][x-2] == 'A' && grid[y][x-3] == 'S')
            {
                increment();
            }
        }
        
        
        // top to bottom
        if (y + wordLength < grid.Length)
        {
            if (grid[y+1][x] == 'M' && grid[y+2][x] == 'A' && grid[y+3][x] == 'S')
            {
                increment();
            }
        }
        
        // bottom to top
        if (y - wordLength >= 0)
        {
            if (grid[y-1][x] == 'M' && grid[y-2][x] == 'A' && grid[y-3][x] == 'S')
            {
                increment();
            }
        }
        
        
        // diagonal up right
        if (y - wordLengthDiag >= 0 && x + wordLengthDiag < lineLength)
        {
            if (grid[y-1][x+1] == 'M' && grid[y-2][x+2] == 'A' && grid[y-3][x+3] == 'S')
            {
                increment();
            }
        }
        
        
        // diagonal up left
        if (y - wordLengthDiag >= 0 && x - wordLengthDiag >= 0 )
        {
            if (grid[y-1][x-1] == 'M' && grid[y-2][x-2] == 'A' && grid[y-3][x-3] == 'S')
            {
                increment();
            }
        }
        
        // diagonal down right
        if (y + wordLengthDiag < grid.Length && x + wordLengthDiag < lineLength)
        {
            if (grid[y+1][x+1] == 'M' && grid[y+2][x+2] == 'A' && grid[y+3][x+3] == 'S')
            {
                increment();
            }
        }
        
        // diagonal down left
        if (y + wordLengthDiag < grid.Length && x - wordLengthDiag >= 0)
        {
            if (grid[y+1][x-1] == 'M' && grid[y+2][x-2] == 'A' && grid[y+3][x-3] == 'S')
            {
                increment();
            }
        }

        return res;
    }
    
}