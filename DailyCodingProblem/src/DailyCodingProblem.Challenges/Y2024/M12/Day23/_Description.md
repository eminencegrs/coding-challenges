This problem was asked by Slack.

You are given an `N` by `M` matrix of `0` and `1`.  

**Starting from the top left corner, how many ways are there to reach the bottom right corner?**  

 - You can only move right and down.
 - `0` represents an empty space while `1` represents a wall you cannot walk through.

## Examples:

Given the following matrix:

```
[
    [ 0, 0, 1 ],
    [ 0, 0, 1 ],
    [ 1, 0, 0 ]
]
```

Return two, as there are only 2 ways to get to the bottom right:

 - Right, down, down, right
 - Down, right, down, right

The top left corner and bottom right corner will always be 0.
