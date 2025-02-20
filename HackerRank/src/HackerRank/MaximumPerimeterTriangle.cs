﻿namespace HackerRank;

// Given an array of stick lengths, use 3 of them to construct a non-degenerate triangle
// with the maximum possible perimeter.
// Return an array of the lengths of its sides as 3 integers in non-decreasing order.
// 
// If there are several valid triangles having the maximum perimeter:
//  - Choose the one with the longest maximum side.
//  - If more than one has that maximum, choose from them the one with the longest minimum side.
//  - If more than one has that maximum as well, print any one them.
//
// If no non-degenerate triangle exists, return [-1].
//
// Constraints:
//  -- 3 <= n <= 50
//  -- 1 <= sticks[i] <= 10^9
//
// Example:
// sticks = [1, 2, 3, 4, 5, 10]
// The triplet (1, 2, 3) will not form a triangle.
// Neither will (4, 5, 10) or (2, 3, 5), so the problem is reduced to (2, 3, 4) and (3, 4, 5).
// The longer perimeter is 3 + 4 + 5 = 12.

// Time Complexity: O(nlog(n)).
public static class MaximumPerimeterTriangle
{
    public static List<int> GetSides(List<int> sticks)
    {
        sticks.Sort();

        for (int i = sticks.Count - 3; i >= 0; i--)
        {
            int a = sticks[i];
            int b = sticks[i + 1];
            int c = sticks[i + 2];

            if (a + b > c)
            {
                return [a, b, c];
            }
        }

        return [-1];
    }
}
