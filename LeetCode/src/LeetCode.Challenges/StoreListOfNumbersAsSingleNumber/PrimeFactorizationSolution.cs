using System;
using System.Collections.Generic;

namespace LeetCode.Challenges.StoreListOfNumbersAsSingleNumber;

public class PrimeFactorizationEncoding
{
    public static long Encode(int[] numbers)
    {
        var primes = GeneratePrimes(numbers.Length);
        long encodedNumber = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            encodedNumber *= (long)Math.Pow(primes[i], numbers[i]);
        }

        return encodedNumber;
    }

    public static List<int> Decode(long encodedNumber, int size)
    {
        List<int> primes = GeneratePrimes(size);
        List<int> decodedList = new List<int>();

        foreach (int prime in primes)
        {
            int exponent = 0;
            while (encodedNumber % prime == 0)
            {
                encodedNumber /= prime;
                exponent++;
            }
            decodedList.Add(exponent);
        }

        return decodedList;
    }

    private static List<int> GeneratePrimes(int n)
    {
        int limit = n * 10;
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= limit; i++)
        {
            if (!isPrime[i])
            {
                continue;
            }

            for (int j = i * i; j <= limit; j += i)
            {
                isPrime[j] = false;
            }
        }

        List<int> primes = [];
        for (int i = 2; i <= limit && primes.Count < n; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}