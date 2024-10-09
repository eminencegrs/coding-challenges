using System;
using System.Threading;

namespace LeetCode.Challenges.PrintInOrder;

public class SemaphoreSlimSolution : IDisposable
{
    private readonly SemaphoreSlim secondSemaphore = new(0);
    private readonly SemaphoreSlim thirdSemaphore = new(0);

    public void First(Action printFirst)
    {
        printFirst();

        // Signal that second() can now run.
        this.secondSemaphore.Release();
    }

    public void Second(Action printSecond)
    {
        // Wait for first() to complete.
        this.secondSemaphore.Wait();

        printSecond();

        // Signal that third() can now run.
        this.thirdSemaphore.Release();
    }

    public void Third(Action printThird)
    {
        // Wait for second() to complete.
        this.thirdSemaphore.Wait();
        printThird();
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        this.secondSemaphore?.Dispose();
        this.thirdSemaphore?.Dispose();
    }
}
