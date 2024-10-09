using System;
using System.Threading;

namespace LeetCode.Challenges.PrintInOrder;

public class ManualResetEventSolution : IDisposable
{
    private readonly ManualResetEvent firstDone = new(false);
    private readonly ManualResetEvent secondDone = new(false);

    public void First(Action printFirst)
    {
        printFirst();

        // Signal that first() has completed.
        this.firstDone.Set();
    }

    public void Second(Action printSecond)
    {
        // Wait for first() to complete.
        this.firstDone.WaitOne();

        printSecond();

        // Signal that second() has completed.
        this.secondDone.Set();
    }

    public void Third(Action printThird)
    {
        // Wait for second() to complete.
        this.secondDone.WaitOne();

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

        this.firstDone?.Dispose();
        this.secondDone?.Dispose();
    }
}
