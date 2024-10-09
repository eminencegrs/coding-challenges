using System;
using System.Threading;

namespace LeetCode.Challenges.PrintInOrder;

public class SemaphoreSlimSolution : IDisposable
{
    private readonly SemaphoreSlim secondSemaphore = new(0);
    private readonly SemaphoreSlim thirdSemaphore = new(0);

    private bool isDisposed;

    public void First(Action printFirst)
    {
        this.AssertNotDisposed();

        printFirst();

        // Signal that the Second method can now run.
        this.secondSemaphore.Release();
    }

    public void Second(Action printSecond)
    {
        this.AssertNotDisposed();

        // Wait for the First method to complete.
        this.secondSemaphore.Wait();

        printSecond();

        // Signal that the Third method can now run.
        this.thirdSemaphore.Release();
    }

    public void Third(Action printThird)
    {
        this.AssertNotDisposed();

        // Wait for the Second method to complete.
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
        if (this.isDisposed)
        {
            return;
        }

        if (!disposing)
        {
            return;
        }

        this.secondSemaphore?.Dispose();
        this.thirdSemaphore?.Dispose();

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
