using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public class CountIslands
    {

        private static int n;
        private static int m;

        public int NumIslands(char[][] grid)
        {
            int count = 0;
            n = grid.Length;
            if (n == 0) return 0;
            m = grid[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        MarkIslands(grid, i, j);
                        ++count;
                    }
                }                 
            }
            return count;
        }

        public static void MarkIslands(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= n || j >= m || grid[i][j] != '1') return;
            grid[i][j] = '0';
            MarkIslands(grid, i + 1, j);
            MarkIslands(grid, i - 1, j);
            MarkIslands(grid, i, j + 1);
            MarkIslands(grid, i, j - 1);
        }
    }
}
