namespace LeetCode.Challenges.SquareRoot;

public class BruteForceSolution
{
    public static int GetResult(int x)
    {
        if (x < 2)
        {
            return x;
        }

        ulong casted = (ulong)x; 
        var result = 0;
        for (ulong i = 1; i < casted; i++)
        {
            ulong temp = i * i;
            if (temp == casted)
            {
                result = (int)i;
                break;
            }

            if (temp < casted)
            {
                result = (int)i;
            }

            if (temp > casted)
            {
                break;
            }
        }

        return result;
    }
}
