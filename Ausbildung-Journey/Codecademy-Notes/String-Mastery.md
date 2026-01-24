# 🧶 String Mastery Notes

**Date:** Jan 24, 2026 (Saturday)
**Topic:** Manipulating Text (The "CargoNerds" Skill)

## 1. The "Case" Problem
Computers are dumb.
*   "Hamburg" != "HAMBURG" != "hamburg"
*   In Logistics, this causes lost containers.

## 2. The Solution: Normalization
We force everything to look the same.
*   **`.ToUpper()`**: SCREAMING CASE (Standard for Container IDs).
*   **`.ToLower()`**: whispering case (Standard for emails).

## 3. The "Save Button" Rule (CRITICAL)
In C#, Strings are **Immutable** (Frozen).
If you change them, you must **SAVE** the result back to the variable.

**WRONG (The Change is lost):**
```csharp
string city = "Berlin";
city.ToUpper(); // Computer creates "BERLIN", then throws it away.
Console.WriteLine(city); // Prints "Berlin" (Fail)
```

**RIGHT (The Change is saved):**
```csharp
string city = "Berlin";
city = city.ToUpper(); // "Save 'BERLIN' into the box 'city'"
Console.WriteLine(city); // Prints "BERLIN" (Success)
```

## 4. Summary Quote
> "A string does not change unless you force it to change with an `=` sign."
