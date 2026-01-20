# Day 4: Making Decisions (if/else)

**Date:** Thursday (or Tomorrow)  
**Time:** 5:10 - 5:50 AM  
**Goal:** Make your code "smart" by making decisions.

---

## 📚 What You'll Learn Today:

1.  **`if` statement:** Do something ONLY if a condition is true.
2.  **`else` statement:** Do something else if it's false.
3.  **Logical Operators:** `&&` (AND), `||` (OR).

---

## 🎯 Tasks:

### **Part 1: The Security Check (15 min)**

**Create new project:**
```bash
cd ~/Documents/learning\ /c#/csharp-basics-main/Projects
dotnet new console -n SecurityCheck
cd SecurityCheck
code .
```

**Write this code:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- CLUB SECURITY CHECK ---");
        
        int age = 17; // Change this to test!
        bool hasID = true;

        // Simple IF
        if (age >= 18)
        {
            Console.WriteLine("You are old enough.");
        }
        else
        {
            Console.WriteLine("You are too young! Go home.");
        }

        // Complex IF (AND operator)
        // Both specific conditions must be true: Age >= 18 AND hasID
        if (age >= 18 && hasID == true) 
        {
            Console.WriteLine("ACCESS GRANTED: Welcome to the club! bitchesss");
        }
        else
        {
            Console.WriteLine("ACCESS DENIED: You need to be 18+ AND have an ID.");
        }
    }
}
```

---

### **Part 2: The Grade Calculator (15 min)**

**Goal:** modifying the code to check grades.
- `if` score > 90 -> "A"
- `else if` score > 80 -> "B"
- `else` -> "F"

**We will code this part together live!**

---

## ✅ Checklist
- [ ] Create `SecurityCheck` project
- [ ] Use `if` / `else`
- [ ] Use `&&` (AND)
- [ ] Experiment with changing variables

**See you at 5:00 AM! 🚀**
