# Chapter 1: OOP Introduction - Simple Breakdown

## 1.1 What is a Computer Program?

### **The Simple Answer:**
A program has 2 main jobs:
1. **Model the real world** (represent things like customers, orders, vehicles)
2. **Do tasks** (calculate routes, process data)

### **Example: Shipping Company Program**
- **Models:** Customers, Orders, Trucks, Routes
- **Tasks:** Find the best route (cheapest, fastest)

### **Their Example: Fraction Calculator**
Instead of a complex shipping program, they use a **Fraction** (Bruch) calculator:
- Add fractions: 1/2 + 1/3
- Simplify fractions: 4/8 → 1/2

---

## 1.2 Classes and Objects (The Core Concept)

### **Class = Blueprint (Recipe)**
A class describes what something IS and what it can DO.

**Example: Fraction Class (Bruch)**
- **What it IS:** Has a numerator (Zähler) and denominator (Nenner)
- **What it can DO:** Simplify itself, add another fraction

### **Object = Actual Thing (The Cake)**
An object is a specific instance created from the class.

**Example:**
- `fraction1` = 2/3 (an object)
- `fraction2` = 1/4 (another object)

---

## Key Terms (Simple Definitions)

| German | English | What It Means |
|--------|---------|---------------|
| **Klasse** | Class | Blueprint/Template |
| **Objekt** | Object | Actual thing created from blueprint |
| **Felder** | Fields | Data (like numerator, denominator) |
| **Methoden** | Methods | Actions (like simplify, add) |
| **Eigenschaften** | Properties | Safe way to access/change fields |

---

## The Fraction Class Example

### **Fields (Data):**
```csharp
int zaehler;  // numerator (private)
int nenner;   // denominator (private)
```

### **Properties (Safe Access):**
```csharp
public int Zaehler { get; set; }  // Access to zaehler
public int Nenner { get; set; }   // Access to nenner
```

### **Methods (Actions):**
```csharp
Kuerze()           // Simplify the fraction
Addiere(Bruch b)   // Add another fraction
Zeige()            // Display the fraction
```

---

## Why Properties Instead of Direct Access?

**Bad (Direct Access):**
```csharp
fraction.nenner = 0;  // DANGER! Division by zero!
```

**Good (Property with Validation):**
```csharp
public int Nenner {
    set {
        if (value != 0)  // Check: don't allow zero!
            nenner = value;
    }
}
```

---

## UML Diagram (Visual Representation)

```
┌─────────────────┐
│     Bruch       │  ← Class Name
├─────────────────┤
│ Zaehler: int    │  ← Properties (Data)
│ Nenner: int     │
├─────────────────┤
│ Kuerze()        │  ← Methods (Actions)
│ Addiere(Bruch)  │
│ Zeige()         │
└─────────────────┘
```

---

## The Big Picture

**Think of it like a car:**
- **Class = Car Blueprint**
  - Fields: color, speed, fuel
  - Methods: drive(), brake(), honk()

- **Object = Your Actual Car**
  - color = "red"
  - speed = 60
  - You can call: myCar.drive()

---

## What You Should Remember

1. **Class** = Blueprint (defines structure)
2. **Object** = Actual instance (created from class)
3. **Fields** = Data (private, hidden)
4. **Properties** = Safe access to fields (public)
5. **Methods** = Actions the object can do

---

## Next Steps

Don't worry about the code details yet. Just understand:
- Classes are templates
- Objects are real things
- Objects have data (fields) and actions (methods)

**Tomorrow:** We'll see how to actually CREATE objects and use them.
