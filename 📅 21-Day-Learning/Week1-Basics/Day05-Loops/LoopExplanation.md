# 🔄 Understanding the FOR Loop

You asked about this line:
`for (int i = 1; i <= 10; i++)`

Think of it as a **Runner on a Track**.

## The 3 Parts
It has 3 instructions separated by semicolons `;`.

1.  **THE START LINE** (`int i = 1`)
    *   "Runner, start at marker #1."
    *   `i` is just a variable (stands for **Index** or **Iterator**). You could call it `count` or `x`.

2.  **THE FINISH LINE** (`i <= 10`)
    *   "Keep running as long as you are at marker 10 or less."
    *   Before *every* step, the computer checks: "Am I past 10 yet?"
    *   If `i` is 11, it stops immediately.

3.  **THE JUMP** (`i++`)
    *   "After each step, move forward by 1."
    *   `i++` is short for `i = i + 1`.
    *   You could do `i = i + 2` to skip numbers (1, 3, 5...).

## Visualizing execution
| Round | Value of i | Is i <= 10? | Action | Next Step |
|-------|------------|-------------|--------|-----------|
| 1st | 1 | YES | Run Code | i becomes 2 |
| 2nd | 2 | YES | Run Code | i becomes 3 |
| ... | ... | ... | ... | ... |
| 10th | 10 | YES | Run Code | i becomes 11 |
| 11th | 11 | **NO** | STOP! | Exit Loop |
