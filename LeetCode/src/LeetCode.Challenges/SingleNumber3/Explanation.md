# Explanation with an example

Let's analyze the code step-by-step using an example. Assume the input array is:

```csharp
int[] numbers = { 1, 2, 1, 3, 2, 5 };
```

### Step 1: XOR all numbers to get the XOR of the two unique numbers.

We'll XOR all numbers in the array. Numbers that appear twice will cancel each other out, leaving the XOR of the two unique numbers (in this case, `3` and `5`).

| Number | Binary       | XOR result (intermediate) |
|--------|--------------|---------------------------|
| 1      | `0001`       | `0001`                    |
| 2      | `0010`       | `0001 ^ 0010 = 0011`      |
| 1      | `0001`       | `0011 ^ 0001 = 0010`      |
| 3      | `0011`       | `0010 ^ 0011 = 0001`      |
| 2      | `0010`       | `0001 ^ 0010 = 0011`      |
| 5      | `0101`       | `0011 ^ 0101 = 0110`      |

After XORing all numbers, `xorResult = 0110` - which is `6` in decimal.  
So, the result of XORing all numbers is `0110` (`6`), which represents `3 ^ 5`.

### Step 2: Find the rightmost bit (RMB) where the two unique numbers differ.

To find the bit where the two unique numbers differ, we use the expression:

```csharp
int distinguishingBit = xorResult & -xorResult;
```

Let's break this down:
- `xorResult = 0110` (`6` in decimal).
- The two's complement of `xorResult` (i.e., `-xorResult`) is calculated by inverting the bits and adding 1:
  - Inverting `0110` gives `1001`.
  - Adding `1` gives `1010` (`-xorResult` is `1010` or `-6` in decimal).

Now, compute `xorResult & -xorResult`:
``` 
0110 (xorResult)
&
1010 (-xorResult)
----
0010 (distinguishingBit)
```

The result is `0010` (which is `2` in decimal).  
This bit (the second bit from the right) tells us where the two numbers differ.

### Step 3: Split the numbers into two groups based on the distinguishing bit and XOR them.

Now, we'll divide the numbers into two groups:
- those where the distinguishing bit (second bit) is `1`
- and those where it's `0`.

Then, we XOR the numbers in each group.
Let's check each number and group them:

| Number | Binary       | RMB (second bit) | Group                |
|--------|--------------|------------------|----------------------|
| 1      | `0001`       | `0`              | Group 2 (unique2)    |
| 2      | `0010`       | `1`              | Group 1 (unique1)    |
| 1      | `0001`       | `0`              | Group 2 (unique2)    |
| 3      | `0011`       | `1`              | Group 1 (unique1)    |
| 2      | `0010`       | `1`              | Group 1 (unique1)    |
| 5      | `0101`       | `0`              | Group 2 (unique2)    |

**Group 1** (second bit = `1`): { 2, 3, 2 }  
**Group 2** (second bit = `0`): { 1, 1, 5 }

Now, XOR the numbers in each group:

- **Group 1**:
  ``` 
  2 ^ 3 ^ 2 = 0010 ^ 0011 ^ 0010 = 0011 (which is 3)
  ```

- **Group 2**:
  ``` 
  1 ^ 1 ^ 5 = 0001 ^ 0001 ^ 0101 = 0101 (which is 5)
  ```

### Step 4: Return the two unique numbers.

The two unique numbers are `3` and `5`. The method returns:

```csharp
return [3, 5];
```

## Summary of Results:
- After XORing all the numbers, we get `xorResult = 0110` (which is `3 ^ 5`).
- The distinguishing bit is `0010` (the second bit).
- We split the numbers into two groups and XOR them, resulting in `3` and `5`.
