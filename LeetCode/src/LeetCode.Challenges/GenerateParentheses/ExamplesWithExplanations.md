## Examples with explanations

### Example 1

Input: `n = 2`

**Explanation:**

```
GenerateParenthesis(2)
    └── Handle("", 0, 0, 2)
           |
           ├── "(" added → Handle("(", 1, 0, 2)
           |      |
           |      ├── "(" added → Handle("((", 2, 0, 2)
           |      |      |
           |      |      ├── ")" added → Handle("(()", 2, 1, 2)
           |      |      |      |
           |      |      |      ├── ")" added → Handle("(())", 2, 2, 2)  <-- [Base case reached, add "(())" to result]
           |      |      |      |
           |      |      |      ← Backtrack to Handle("(()", 2, 1, 2)
           |      |      |
           |      |      ← Backtrack to Handle("((", 2, 0, 2)
           |      |
           |      ← Backtrack to Handle("(", 1, 0, 2)
           |
           ├── ")" added → Handle("()", 1, 1, 2)
           |      |
           |      ├── "(" added → Handle("()(", 2, 1, 2)
           |      |      |
           |      |      ├── ")" added → Handle("()()", 2, 2, 2)  <-- [Base case reached, add "()()" to result]
           |      |      |
           |      |      ← Backtrack to Handle("()(", 2, 1, 2)
           |      |
           |      ← Backtrack to Handle("()", 1, 1, 2)
           |
           ← Backtrack to Handle("", 0, 0, 2)
```

### Example 2

Input: `n = 3`

**Explanation:**

```
GenerateParenthesis(3)
    └── Handle("", 0, 0, 3)
           |
           ├── "(" added → Handle("(", 1, 0, 3)
           |      |
           |      ├── "(" added → Handle("((", 2, 0, 3)
           |      |      |
           |      |      ├── "(" added → Handle("(((", 3, 0, 3)
           |      |      |      |
           |      |      |      ├── ")" added → Handle("((()", 3, 1, 3)
           |      |      |      |      |
           |      |      |      |      ├── ")" added → Handle("((())", 3, 2, 3)
           |      |      |      |      |      |
           |      |      |      |      |      ├── ")" added → Handle("((()))", 3, 3, 3)  ← Base case, add "((()))" to result
           |      |      |      |      |      |
           |      |      |      |      |      ← Backtrack to Handle("((())", 3, 2, 3)
           |      |      |      |      |
           |      |      |      |      ← Backtrack to Handle("((()", 3, 1, 3)
           |      |      |      |
           |      |      |      ← Backtrack to Handle("(((", 3, 0, 3)
           |      |      |
           |      |      ├── ")" added → Handle("(()", 2, 1, 3)
           |      |      |      |
           |      |      |      ├── "(" added → Handle("(()(", 3, 1, 3)
           |      |      |      |      |
           |      |      |      |      ├── ")" added → Handle("(()()", 3, 2, 3)
           |      |      |      |      |      |
           |      |      |      |      |      ├── ")" added → Handle("(()())", 3, 3, 3)  ← Base case, add "(()())" to result
           |      |      |      |      |      |
           |      |      |      |      |      ← Backtrack to Handle("(()()", 3, 2, 3)
           |      |      |      |      |
           |      |      |      |      ← Backtrack to Handle("(()(", 3, 1, 3)
           |      |      |      |
           |      |      |      ← Backtrack to Handle("(()", 2, 1, 3)
           |      |      |
           |      |      ├── ")" added → Handle("(())", 2, 2, 3)
           |      |      |      |
           |      |      |      ├── "(" added → Handle("(())(", 3, 2, 3)
           |      |      |      |      |
           |      |      |      |      ├── ")" added → Handle("(())()", 3, 3, 3)  ← Base case, add "(())()" to result
           |      |      |      |      |
           |      |      |      |      ← Backtrack to Handle("(())(", 3, 2, 3)
           |      |      |      |
           |      |      |      ← Backtrack to Handle("(())", 2, 2, 3)
           |      |      |
           |      |      ← Backtrack to Handle("((", 2, 0, 3)
           |      |
           |      ← Backtrack to Handle("(", 1, 0, 3)
           |
           ├── ")" added → Handle("()", 1, 1, 3)
           |      |
           |      ├── "(" added → Handle("()(", 2, 1, 3)
           |      |      |
           |      |      ├── "(" added → Handle("()((", 3, 1, 3)
           |      |      |      |
           |      |      |      ├── ")" added → Handle("()(()", 3, 2, 3)
           |      |      |      |      |
           |      |      |      |      ├── ")" added → Handle("()(())", 3, 3, 3)  ← Base case, add "()(())" to result
           |      |      |      |      |
           |      |      |      |      ← Backtrack to Handle("()(()", 3, 2, 3)
           |      |      |      |
           |      |      |      ← Backtrack to Handle("()((", 3, 1, 3)
           |      |      |
           |      |      ├── ")" added → Handle("()()", 2, 2, 3)
           |      |      |      |
           |      |      |      ├── "(" added → Handle("()()(", 3, 2, 3)
           |      |      |      |      |
           |      |      |      |      ├── ")" added → Handle("()()()", 3, 3, 3)  ← Base case, add "()()()" to result
           |      |      |      |      |
           |      |      |      |      ← Backtrack to Handle("()()(", 3, 2, 3)
           |      |      |      |
           |      |      |      ← Backtrack to Handle("()()", 2, 2, 3)
           |      |      |
           |      |      ← Backtrack to Handle("()(", 2, 1, 3)
           |      |
           |      ← Backtrack to Handle("()", 1, 1, 3)
           |
           ← Backtrack to Handle("", 0, 0, 3)
```
