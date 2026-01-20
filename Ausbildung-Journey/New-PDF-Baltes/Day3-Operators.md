# Day 3: Operators & Explicit Conversion

**Date:** Tomorrow (Tuesday/Wednesday)  
**Time:** 5:10 - 5:50 AM  
**Goal:** Master "Unsafe" Conversion and Math Operators

---

## 📚 What You'll Learn Today:

1.  **Explicit Conversion** (Casting: The dangerous stuff we skipped yesterday)
2.  **Math Operators** (+, -, *, /, %)
3.  **Building a Calculator**

---

## 🎯 Tasks:

### **Part 1: The Dangerous Stuff (Explicit Conversion) - 10 min**

**Open your `DataTypes` project from yesterday:**
```bash
cd ~/Documents/learning\ /c#/csharp-basics-main/Projects/DataTypes
code .
```

**Add this to `Program.cs`:**
```csharp
// --- PART 3: Explicit Conversion (Manual/Dangerous) ---
double price = 99.99;
int priceInt = (int)price; // Force it to be an int (Casting)

Console.WriteLine("\n--- Explicit Conversion ---");
Console.WriteLine("Original price: " + price);
Console.WriteLine("Casted integer: " + priceInt); // Watch the .99 disappear!
```

**Run it:** `dotnet run` -> See the data loss?

---

### **Part 2: Math Operators - 15 min**

**Create new project for today:**
```bash
cd ~/Documents/learning\ /c#/csharp-basics-main/Projects
dotnet new console -n Operators
cd Operators
code .
```

**Write this code:**
```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 3;

        Console.WriteLine($"Addition: {a} + {b} = " + (a + b));
        Console.WriteLine($"Subtraction: {a} - {b} = " + (a - b));
        Console.WriteLine($"Multiplication: {a} * {b} = " + (a * b));
        Console.WriteLine($"Division: {a} / {b} = " + (a / b)); // Wait, 10/3 is 3?
        Console.WriteLine($"Remainder (%): {a} % {b} = " + (a % b)); // The leftover 1
        
        // Fix Division (use double)
        double aDouble = 10.0;
        Console.WriteLine($"Real Division: {aDouble} / {b} = " + (aDouble / b));
    }
}
```

---

### **Part 3: Mini Challenge - 15 min**

**Goal:** Create a simple Age Calculator.
1. Declare existing year: `int currentYear = 2026;`
2. Declare birth vear: `int birthYear = 2000;` (or yours)
3. Calculate age: `int age = currentYear - birthYear;`
4. Print: "You are approx [age] years old."

---

## ✅ Checklist
- [ ] Explicit conversion (force data loss)
- [ ] Basic math (+ - * /)
- [ ] Understand Integer Division (10/3 = 3)
- [ ] Understand Modulo (10%3 = 1)
- [ ] Build Age Calculator

**See you at 5:00 AM! 🚀**
