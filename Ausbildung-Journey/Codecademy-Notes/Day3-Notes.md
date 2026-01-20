# 📝 Notes: Numbers & Strings (Day 3 Extra)

**Date:** Jan 20, 2026
**Source:** Codecademy

## 1. Math Tricks
*   **`Math.Floor()`**: Rounds DOWN. (Good for "How many full boxes?").
*   **`Math.Ceiling()`**: Rounds UP. (Good for "How many trucks needed?").
*   **`Math.Sqrt()`**: Square Root. (Rarely used in logistics).
*   **`Math.Abs()`**: Absolute Value (removing the negative sign).
    *   *Tricky Moment:* Calculating `Sqrt` of a negative number returns `NaN` unless you use `Abs` first!

## 2. String Secrets
*   **Escape Quotes:** To put a `"` inside a string, use `\"`.
    ```csharp
    string quote = "\"Hello\" he said.";
    ```
*   **Interpolation (The Professional Way):**
    ```csharp
    string msg = $"User {name} is {age} years old.";
    ```
*   **Searching Strings:**
    *   `.Length`: How many characters?
    *   `.IndexOf("text")`: Where is it? (Returns -1 if missing).
*   **The "DNA" Mutation (Substring):**
    *   `.Substring(startIndex, length)`: cutting a piece of text.
    *   `string[index]`: accessing a single character letter.

## 🧠 Key Takeaway
"Codecademy showed me the map, but the Morning Routine is where I hike the mountain."
