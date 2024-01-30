namespace HackerRank.Week1;

public class FlippingBits
{
    public long FlipBits(long n)
    {
        uint number = (uint)n;
        long result = ~number;
        return result;
    }
}
