namespace LeetCode.Challenges.PrintFooBarAlternately;

public class TwoSemaphoreSlimSolution : IDisposable
{
    private readonly SemaphoreSlim fooSemaphore = new(1);
    private readonly SemaphoreSlim barSemaphore = new(0);

    private readonly int number;

    private volatile bool isDisposed;

    public TwoSemaphoreSlimSolution(int number)
    {
        this.number = number;
    }

    public void Foo(Action printFoo)
    {
        this.AssertNotDisposed();

        for (int i = 0; i < this.number; i++)
        {
            this.fooSemaphore.Wait();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            this.barSemaphore.Release();
        }
    }

    public void Bar(Action printBar)
    {
        this.AssertNotDisposed();

        for (int i = 0; i < this.number; i++)
        {
            this.barSemaphore.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            this.fooSemaphore.Release();
        }
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

        this.fooSemaphore?.Dispose();
        this.barSemaphore?.Dispose();

        this.isDisposed = true;
    }

    private void AssertNotDisposed()
    {
        if (this.isDisposed)
        {
            throw new ObjectDisposedException(nameof(TwoSemaphoreSlimSolution));
        }
    }
}
