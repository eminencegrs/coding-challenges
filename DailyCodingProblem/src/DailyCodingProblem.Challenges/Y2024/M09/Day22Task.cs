namespace DailyCodingProblem.Challenges.Y2024.M09;

// This problem was asked by Google.
//
// Implement an LFU (Least Frequently Used) cache.
// It should be able to be initialized with a cache size `n`, and contain the following methods:
// -- set(key, value): sets key to value.
//    If there are already `n` items in the cache and we are adding a new item,
//    then it should also remove the least frequently used item.
//    If there is a tie, then the least recently used key should be removed.
// -- get(key): gets the value at key. If no such key exists, return `null`.
//
// Each operation should run in O(1) time.
//
// Summary:
// Both the `Get` and `Set` methods operate in O(1) time complexity due to efficient use of
// -- dictionaries for lookups
// -- and linked lists for frequency grouping.
public class LfuCache
{
    private readonly Dictionary<int, KeyValuePair<int, int>> frequenciesAndValuesByKeys = new();
    private readonly Dictionary<int, LinkedList<int>> keysByFrequencies = new();

    private readonly int capacity;

    private int size = 0;
    private int minFrequency = 0;

    public LfuCache(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (!this.frequenciesAndValuesByKeys.TryGetValue(key, out var frequencyValuePair))
        {
            return -1;
        }
    
        var frequency = frequencyValuePair.Key;
        var value = frequencyValuePair.Value;

        // Remove the key from the old frequency group.
        this.keysByFrequencies[frequency].Remove(key); 

        // Re-insert the key with incremented frequency.
        this.Insert(key, value, frequency + 1);

        if (this.minFrequency == frequency && this.keysByFrequencies[frequency].Count == 0)
        {
            this.minFrequency++;
        }

        return value;
    }

    public void Set(int key, int value)
    {
        if (this.capacity == 0)
        {
            return;
        }

        if (this.frequenciesAndValuesByKeys.TryGetValue(key, out var frequencyValuePair))
        {
            var frequency = frequencyValuePair.Key;
            this.keysByFrequencies[frequency].Remove(key);
            this.Insert(key, value, frequency + 1);
            if (this.minFrequency == frequency && this.keysByFrequencies[frequency].Count == 0)
            {
                this.minFrequency++;
            }
        }
        else
        {
            this.size++;

            if (this.size > this.capacity)
            {
                this.RemoveLeastFrequentlyUsed();
            }

            this.Insert(key, value, 1);
            this.minFrequency = 1;
        }
    }

    private void Insert(int key, int value, int frequency)
    {
        var newFrequencyValuePair = new KeyValuePair<int, int>(frequency, value);
        this.frequenciesAndValuesByKeys[key] = newFrequencyValuePair;

        if (!this.keysByFrequencies.TryGetValue(frequency, out var keysGroupedByFrequency))
        {
            keysGroupedByFrequency = new LinkedList<int>();
            this.keysByFrequencies.Add(frequency, keysGroupedByFrequency);
        }

        keysGroupedByFrequency.AddLast(key);
    }

    private void RemoveLeastFrequentlyUsed()
    {
        if (this.keysByFrequencies[this.minFrequency].Count == 0)
        {
            return;
        }

        var itemToRemove = this.keysByFrequencies[this.minFrequency].First;
        this.frequenciesAndValuesByKeys.Remove(itemToRemove!.Value);
        this.keysByFrequencies[this.minFrequency].RemoveFirst();
        this.size--;
    }
}
