# Climbing Stairs

You are climbing a staircase. It takes `n` steps to reach the top.  
Instead of being able to climb `1` or `2` steps at a time,  
we can climb **any number** from a set of positive integers `X`.  

For example, if `X = {1, 3, 5}`, we can climb 1, 3, or 5 steps at a time.  

**We need to generalize a function to take in `X`.**  

## Examples

### Example 1:

yield return [ 3, new[] { 1, 2, 3 }, 4 ];
Input:  
 - `n = 3`
 - `Step Sizes = [ 1, 2, 3 ]`
Output: `4`

Explanation: There are 4 unique ways to climb to the top.
1. 1 step + 1 step + 1 step + 1 step
2. 1 step + 1 step + 2 steps
3. 1 step + 3 steps
4. 2 steps + 2 steps
