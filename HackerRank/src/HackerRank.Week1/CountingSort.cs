namespace HackerRank.Week1;

public class CountingSort
{
    public List<int> Sort(List<int> inputArray)
    {
        var maxValue = inputArray.Max();
        var countArray = new int[maxValue + 1];
        for (var i = 0; i < inputArray.Count; i++)
        {
            countArray[inputArray[i]]++;
        }
        
        for (var i = 1; i <= maxValue; i++)
        {
            countArray[i] += countArray[i - 1];
        }
        
        var outputArray = new int[inputArray.Count];
 
        for (var i = inputArray.Count - 1; i >= 0; i--)
        {
            outputArray[countArray[inputArray[i]] - 1] = inputArray[i];
            countArray[inputArray[i]]--;
        }

        return outputArray.ToList();
    }
    
    public List<int> Challenge(List<int> inputArray)
    {
        var maxValue = inputArray.Max();
        var countArray = new int[maxValue + 1];
        for (var i = 0; i < inputArray.Count; i++)
        {
            countArray[inputArray[i]]++;
        }
        
        return countArray.ToList();
    }
}