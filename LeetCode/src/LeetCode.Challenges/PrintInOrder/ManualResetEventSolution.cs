using System;
using System.Threading;

namespace LeetCode.Challenges.PrintInOrder;

public class ManualResetEventSolution : IDisposable
{
    private readonly ManualResetEvent firstDone = new(false);
    private readonly ManualResetEvent secondDone = new(false);

    private bool isDisposed;

    public void First(Action printFirst)
    {
        this.AssertNotDisposed();

        printFirst();

        // Signal that the First method has completed.
        this.firstDone.Set();
    }

    public void Second(Action printSecond)
    {
        this.AssertNotDisposed();

        // Wait for the First method to complete.
        this.firstDone.WaitOne();

        printSecond();

        // Signal that the Second method has completed.
        this.secondDone.Set();
    }

    public void Third(Action printThird)
    {
        this.AssertNotDisposed();

        // Wait for the Second method to complete.
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
        if (this.isDisposed)
        {
            return;
        }

        if (!disposing)
        {
            return;
        }

        this.firstDone?.Dispose();
        this.secondDone?.Dispose();

        this.isDisposed = true;
    }

    private void AssertNotDisposed()
    {
        if (this.isDisposed)
        {
            throw new ObjectDisposedException(nameof(ManualResetEventSolution));
        }
    }
}
