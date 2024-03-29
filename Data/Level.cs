﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Races.Data
{
    static class Level
    {
        #region Levels
        public static int[][] template = new int[][]
        {
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  13,  14,  14,  14,  15,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   3,   1,   7,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   2,   9,   8,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,  12,  10,  10,  10,  16,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,  11,  18,  18,  18,  17,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
            new int[] { 0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0,   0},
        };

        public static int[][] start = new int[][]
{
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 4, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1},
            new int[] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
};

        #endregion

    }
}
