## Explanation

### How the formula `(i / 3) * 3 + (j / 3)` works

The formula `(i / 3) * 3 + (j / 3)` calculates the unique index for each 3x3 sub-grid (or "square") in the Sudoku board.  

Here's a detailed explanation:

 - The Sudoku board is a 9x9 grid divided into 9 smaller 3x3 grids (called "squares"). 
   Each square is identified by its row and column positions in the grid.

 - The **row group** of a square is determined by dividing the row index `i` by 3. For example:
   - Rows `0, 1, 2` belong to the first row group.
   - Rows `3, 4, 5` belong to the second row group.
   - Rows `6, 7, 8` belong to the third row group.

 - The **column group** of a square is determined by dividing the column index `j` by 3. For example:
   - Columns `0, 1, 2` belong to the first column group.
   - Columns `3, 4, 5` belong to the second column group.
   - Columns `6, 7, 8` belong to the third column group.

To uniquely identify each square, combine the row group and column group:

 - Multiply the row group (`i / 3`) by 3 to shift it into its unique position.
 - Add the column group (`j / 3`).

This results in a unique index for each square, ranging from `0` to `8`:

| **Square Index**  | **Rows** | **Columns** |
|-------------------|----------|-------------|
| 0                 | 0-2      | 0-2         |
| 1                 | 0-2      | 3-5         |
| 2                 | 0-2      | 6-8         |
| 3                 | 3-5      | 0-2         |
| 4                 | 3-5      | 3-5         |
| 5                 | 3-5      | 6-8         |
| 6                 | 6-8      | 0-2         |
| 7                 | 6-8      | 3-5         |
| 8                 | 6-8      | 6-8         |

**Why does this formula work?**

Given a cell at `(i, j)`:

1. `i / 3` determines the row group of the square (0, 1, or 2).
2. `j / 3` determines the column group of the square (0, 1, or 2).
3. Multiplying the row group by 3 ensures proper offset for the column group.

This creates a **flat index system** to represent the 9 squares using a single number, 
making it easier to store and validate Sudoku rules.

## Questions & ideas

1. Check if it is possible to build a sudoku board where all diagonals contain unique numbers only.
