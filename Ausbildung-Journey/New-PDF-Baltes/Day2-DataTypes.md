# Day 2: Data Types & Type Conversion

**Date:** Tuesday, January 21, 2026  
**Time:** 5:10 - 5:50 AM  
**Goal:** Understand different data types and how to convert between them

---

## 📚 What You'll Learn Today:

1. **Different number types** (int, long, float, double, decimal)
2. **When to use each type**
3. **Implicit conversion** (automatic, safe)
4. **Explicit conversion** (manual, can lose data)

---

## 🎯 Today's Tasks:

### **Part 1: Number Types (15 min)**

**Create new project:**
```bash
cd ~/Documents/learning\ /c#/csharp-basics-main/Projects
dotnet new console -n DataTypes
cd DataTypes
code .
```

**Code to write:**
```csharp
using System;

class Program
{
    static void Main()
    {
        // Integer types (whole numbers)
        int normalNumber = 100;
        long bigNumber = 9999999999;
        
        // Decimal types (numbers with decimals)
        float smallDecimal = 3.14f;      // f = float
        double mediumDecimal = 3.14159;
        decimal preciseDecimal = 3.14159m; // m = decimal
        
        // Print them
        Console.WriteLine("int: " + normalNumber);
        Console.WriteLine("long: " + bigNumber);
        Console.WriteLine("float: " + smallDecimal);
        Console.WriteLine("double: " + mediumDecimal);
        Console.WriteLine("decimal: " + preciseDecimal);
    }
}
```

**Run it:**
```bash
dotnet run
```

---

### **Part 2: Implicit Conversion (10 min)**

**Add this to your code:**
```csharp
// Implicit conversion (automatic, safe)
int small = 100;
long big = small;  // int → long (safe, no data loss)

Console.WriteLine("\nImplicit conversion:");
Console.WriteLine("small (int): " + small);
Console.WriteLine("big (long): " + big);
```

**Why it works:** Small fits into big (like pouring a cup into a bucket)

---

### **Part 3: Explicit Conversion (15 min)**

**Add this:**
```csharp
// Explicit conversion (manual, can lose data)
double price = 99.99;
int roundedPrice = (int)price;  // Cast to int

Console.WriteLine("\nExplicit conversion:");
Console.WriteLine("price (double): " + price);
Console.WriteLine("rounded (int): " + roundedPrice);
Console.WriteLine("Lost data: " + (price - roundedPrice));
```

**Notice:** 99.99 becomes 99 (the .99 is lost!)

---

## ✅ Checklist:

- [ ] Create DataTypes project
- [ ] Declare all number types
- [ ] Print them
- [ ] Try implicit conversion
- [ ] Try explicit conversion
- [ ] Understand the difference

---

## 🎯 Expected Output:

```
int: 100
long: 9999999999
float: 3.14
double: 3.14159
decimal: 3.14159

Implicit conversion:
small (int): 100
big (long): 100

Explicit conversion:
price (double): 99.99
rounded (int): 99
Lost data: 0.99
```

---

**See you at 5:00 AM! 🚀**
