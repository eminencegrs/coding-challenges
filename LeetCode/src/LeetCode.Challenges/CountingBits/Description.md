# Counting Bits

Given an integer `n`, return an array `answers` of length `n + 1` such that 
for each `i` (`0 <= i <= n`), `answers[i]` is the number of 1's in the binary representation of `i`.

## Constraints

`0 <= n <= 10^5`

## Examples

### Example 1:

Input: n = 2  
Output: [0,1,1]  

Explanation:  
0 --> 0  
1 --> 1  
2 --> 10  

### Example 2:

Input: n = 5  
Output: [0,1,1,2,1,2]  

Explanation:  
0 --> 0  
1 --> 1  
2 --> 10  
3 --> 11  
4 --> 100  
5 --> 101  

## Follow up

* It is very easy to come up with a solution with a runtime of O(n log n).
  Is it possible do it in linear time O(n) and possibly in a single pass?

* Is it possible to do it without using any built-in function?

## Hints

* You should make use of what you have produced already.
* Divide the numbers in ranges like [2-3], [4-7], [8-15] and so on. And try to generate new range from previous.
* Or does the odd/even status of the number help you in calculating the number of 1s?

## My example with explanation

1. For i = 1:
   i >> 1 is 0, and (i & 1) is 1. So, result[1] = result[0] + 1 = 0 + 1 = 1.

2. For i = 2:
   i >> 1 is 1, and (i & 1) is 0. So, result[2] = result[1] + 0 = 1 + 0 = 1.

3. For i = 3:
   i >> 1 is 1, and (i & 1) is 1. So, result[3] = result[1] + 1 = 1 + 1 = 2.

4. For i = 4:
   i >> 1 is 2, and (i & 1) is 0. So, result[4] = result[2] + 0 = 1 + 0 = 1.

5. For i = 5:
   i >> 1 is 2, and (i & 1) is 1. So, result[5] = result[2] + 1 = 1 + 1 = 2.
