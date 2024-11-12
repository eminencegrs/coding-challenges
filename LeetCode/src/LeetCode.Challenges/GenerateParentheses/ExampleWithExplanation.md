# Example: n = 2

## Explanation

'''
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
'''