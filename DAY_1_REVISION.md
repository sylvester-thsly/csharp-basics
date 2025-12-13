# 📝 Day 1 Revision: Test Your Understanding

## Instructions
- Answer each question WITHOUT looking at your code
- Write your answer on paper or in a comment
- Then check the answer at the bottom
- If you get it wrong, review that concept again

---

## 🟢 Section 1: Variables & Types

### Question 1
What is the difference between `int` and `double`?

### Question 2
What does this code do?
```csharp
public double WeightKg { get; set; }
```

### Question 3
Fill in the blank:
```csharp
public ____ IsPriority { get; set; }  // For a true/false value
```

### Question 4
What's wrong with this code?
```csharp
public int Distance { get; }  // Missing something?
```

---

## 🟡 Section 2: Classes & Objects

### Question 5
What is a class? Explain it like you're teaching a 10-year-old.

### Question 6
Look at this code:
```csharp
public class ShipmentRecord
{
    public int Id { get; set; }
    public double DistanceKm { get; set; }
}
```
How would you create a new shipment with Distance = 500?

### Question 7
What does `public` mean in `public class EmissionCalculator`?

### Question 8
True or False: A class is like a blueprint, and an object is like a house built from that blueprint.

---

## 🔵 Section 3: Methods

### Question 9
What does this method return?
```csharp
public double CalculateCO2(double distance, double weight)
{
    return distance * weight * 0.002;
}
```

### Question 10
If I call `CalculateCO2(1000, 500)`, what number do I get back?

### Question 11
What's the difference between these two?
```csharp
public void DoSomething() { }
public double CalculateSomething() { }
```

### Question 12
Fill in the blanks:
```csharp
public ____ GetRating(____ emissions)
{
    if (emissions < 100) return "Eco-Friendly";
    return "Heavy";
}
```

---

## 🟣 Section 4: Properties Deep Dive

### Question 13
What does `{ get; set; }` mean? Explain both parts.

### Question 14
What's the difference between these?
```csharp
public int Age { get; set; }      // Option A
public int Age;                    // Option B
```

### Question 15
Can you have `{ get; }` without `set`? What does that mean?

---

## 🔴 Section 5: Your Project

### Question 16
In your own words, what does `ShipmentRecord` represent?

### Question 17
What does this line do in `EmissionsController.cs`?
```csharp
_context.Shipments.Add(record);
```

### Question 18
What's the difference between these two endpoints?
- `POST /api/emissions/calculate`
- `GET /api/emissions/history`

### Question 19
Why did you need to run a "migration" after adding `IsPriority`?

### Question 20
What does `public bool IsPriority { get; set; }` allow you to track?

---

## 🎯 Practical Challenge

### Challenge 1: Write from Memory
Without looking at your code, write the `ShipmentRecord` class with all its properties.

### Challenge 2: Explain the Flow
Explain what happens when someone sends data to `/api/emissions/calculate`. Use these words:
- Request
- Controller
- Calculator
- Database
- Response

### Challenge 3: Spot the Error
What's wrong with this code?
```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public void Subtract(int a, int b)
    {
        return a - b;  // ❌ Error here!
    }
}
```

---

## ✅ ANSWERS (Don't peek until you've tried!)

### Section 1 Answers

**A1:** `int` is for whole numbers (1, 42, -10). `double` is for decimals (3.14, 0.002, 99.99).

**A2:** It creates a property called `WeightKg` that can store decimal numbers. You can read it (`get`) and write to it (`set`).

**A3:** `bool` (because it's true/false)

**A4:** It only has `get`, so you can read it but never change it. You need `{ get; set; }` to make it writable.

---

### Section 2 Answers

**A5:** A class is like a cookie cutter. It defines the shape. An object is the actual cookie you make from it.

**A6:**
```csharp
var shipment = new ShipmentRecord();
shipment.DistanceKm = 500;
// OR
var shipment = new ShipmentRecord { DistanceKm = 500 };
```

**A7:** `public` means anyone can use this class. If it was `private`, only code in the same file could use it.

**A8:** **TRUE!** Perfect analogy.

---

### Section 3 Answers

**A9:** It returns a `double` (decimal number) representing CO2 emissions.

**A10:** `1000 * 500 * 0.002 = 1000` (1000 kg of CO2)

**A11:** 
- `void` means "don't return anything, just do work"
- `double` means "return a decimal number"

**A12:**
```csharp
public string GetRating(double emissions)
```

---

### Section 4 Answers

**A13:**
- `get` = "You can READ this value"
- `set` = "You can WRITE/CHANGE this value"

**A14:**
- Option A is a **property** (modern, recommended)
- Option B is a **field** (old-school, rarely used for public data)

**A15:** Yes! `{ get; }` means "read-only". You can see the value but never change it after it's set.

---

### Section 5 Answers

**A16:** It represents one shipment in the database. It stores the distance, weight, CO2 emission, and when it was created.

**A17:** It adds a new shipment record to the database (but doesn't save it yet—you need `SaveChangesAsync()` for that).

**A18:**
- `POST /calculate` = Send me data, I'll calculate CO2 and save it
- `GET /history` = Give me the list of saved shipments

**A19:** Because you changed the database structure (added a new column). Migrations tell the database "hey, update your table!"

**A20:** Whether a shipment is priority (fast) or standard (slow) shipping.

---

### Practical Answers

**Challenge 1:**
```csharp
public class ShipmentRecord
{
    public int Id { get; set; }
    public double DistanceKm { get; set; }
    public double WeightKg { get; set; }
    public double Co2Emission { get; set; }
    public bool IsPriority { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

**Challenge 2:**
1. User sends a **Request** with distance and weight
2. The **Controller** receives it
3. Controller asks the **Calculator** to do the math
4. Controller saves the result to the **Database**
5. Controller sends back a **Response** with the CO2 number

**Challenge 3:**
`void` methods can't use `return` with a value! It should be:
```csharp
public int Subtract(int a, int b)  // Change void to int
{
    return a - b;
}
```

---

## 📊 Score Yourself

- **18-20 correct:** 🏆 Excellent! You understood everything.
- **15-17 correct:** ✅ Good! Review the ones you missed.
- **12-14 correct:** 🔄 Decent! Re-read the concepts.
- **Below 12:** 📚 Go back to the code and study it again.

---

## 🎯 What to Do Next

1. **If you scored 15+:** You're ready to learn `if` statements tomorrow!
2. **If you scored 12-14:** Review `properties` and `methods` again.
3. **If you scored below 12:** Re-read `LEARN_CSHARP_LESSON_1.md` and try again.

---

**Revision Date:** December 13, 2024  
**Topics Covered:** Variables, Types, Classes, Properties, Methods, Your Project

*Do this quiz again tomorrow morning to test retention!*
