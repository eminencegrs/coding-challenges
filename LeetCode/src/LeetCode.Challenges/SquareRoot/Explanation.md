# Intuition

The problem at hand is to find the integer square root of a non-negative integer `x`. The integer square root is the largest integer `y` such that
`y^2 <= x`.  
A straightforward approach would be to iterate through all possible values from `0` up to `x`, but the brute force algorithm would be inefficient for large values of `x`, while the time complexity would be `O(n)`.  
Using binary search is a practical way to reduce the number of iterations needed to find a solution. This efficient algorithm continually divides the search interval in half, allowing us to quickly converge on the target value.

# Approach

1. Base Case Handling:

If `x` is less than `2`, return `x`. This handles the special cases where `x` is `0` or `1` directly, as their square roots are themselves.

2. Initialization:

Initialize the `left` pointer to `0` and the `right` pointer to `x`. These variables represent the current bounds of the search interval.  
Initialize `result` to `0`. This variable will store the largest integer whose square is less than or equal to `x` during the search.

3. Binary Search Loop:

- While `left` is less than or equal to `right`, perform the following steps:
    - Calculate `mid` as the midpoint of `left` and `right`.
    - Compute `squaredMid` as `mid * mid`.
    - Compare `squaredMid` with `x`:
        - If `squaredMid` is greater than `x`, it means `mid` is too large. Adjust the search interval by setting `right` to `mid - 1`.
        - If `squaredMid` is less than `x`, it means `mid` is too small. Adjust the search interval by setting `left` to `mid + 1` and update `result` to `mid` because `mid` is a potential candidate for the integer square root.
        - If `squaredMid` equals `x`, `mid` is the exact integer square root, and we return `mid` immediately.
- Once the loop exits, return `result`, which contains the largest integer whose square is less than or equal to `x`.

# Complexity

- Time complexity: `O(log(n))`
  This is because the binary search algorithm divides the search interval in half during each iteration, leading to a logarithmic number of steps relative to the size of the input.

- Space Complexity: `O(1)`
  The algorithm uses a constant amount of extra space, regardless of the input size. The variables `left`, `right`, `mid`, `squaredMid`, and `result` all occupy a fixed amount of space.
