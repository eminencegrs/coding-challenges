namespace LeetCode.Challenges.SquareRoot;

// https://en.wikipedia.org/wiki/Newton%27s_method
// Newton's method (also known as the Newton-Raphson method) is an iterative numerical technique
// for finding approximate solutions to equations.
// It works particularly well for finding square roots and is based on the idea of linear approximation.
//
// Given a function f(x) and its derivative f′(x), Newton's method uses the following iterative formula
// to find successively better approximations to the roots (or zeroes) of the function:
// x_(n+1) = x_n - f(x_n) / f'(x_n).
// For the problem of finding the square root of a number x, we can set it up as finding
// the root of the function `f(y) = y^2 - x`. Here we want to find `y` such that `y^2 = x`.
public class NewtonsMethod
{
    public static int GetResult(int x)
    {
        if (x == 1)
        {
            return 1;
        }

        double approximation = x / 2.0;

        while (approximation * approximation - x > 0.5)
        {
            approximation = (approximation + x / approximation) / 2.0;
        }

        return (int)approximation;
    }
}
