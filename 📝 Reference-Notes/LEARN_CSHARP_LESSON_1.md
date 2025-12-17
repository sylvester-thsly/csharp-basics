# Learn C# with CargoNerds: Lesson 1

You already have a working C# program! The best way to learn is to understand what you already have.
Open `Cargonerds.Core/EmissionCalculator.cs` and follow along. Here are the **Big 5 Basics** of C# visible in your code.

## 1. The Container (Namespace & Class)
Think of your code like a warehouse.
*   **namespace**: The general section of the warehouse (e.g., "Core Logic").
*   **class**: A specific blueprint for an object (e.g., "The Calculator Blueprint").

```csharp
namespace Cargonerds.Core          // The "Folder"
{
    public class EmissionCalculator // The "Blueprint"
    {
        // Code goes here...
    }
}
```

## 2. Variables (Storage Boxes)
Variables store data. We have to tell C# what *type* of data (Number? Text? True/False?) goes in the box.
*   **double**: Use this for numbers with decimals (e.g., 10.5, 0.002).
*   **string**: Use this for text (e.g., "Eco-Friendly").

```csharp
private const double EmissionFactor = 0.002; 
// "private" = Only this blueprint can see it.
// "const"   = It never changes.
```

## 3. Methods (The Actions)
Methods are verbs. They DO things.
Structure: `RETURN_TYPE` `NAME` ( `INPUTS` )

```csharp
public double CalculateCO2(double distanceKm, double weightKg)
{
    // Do math...
    return distanceKm * weightKg * EmissionFactor; // Send the result back
}
```

## 4. Conditionals (Logic Flow)
Computers are dumb. You have to tell them "If this happens, do that."

```csharp
if (emissions < 100)
{
    return "Eco-Friendly 🌿";
}
```

## 5. Your First Challenge! 🎯
You are going to write your first lines of C#.

**The Goal**: We want to add a "Super Heavy" warning for really bad shipments.

**Instructions**:
1.  Open `Cargonerds.Core/EmissionCalculator.cs`.
2.  Find the `GetRating` method (around line 21).
3.  Add a new `if` statement **before** the final return.
4.  If emissions are greater than `1000`, return "CRITICAL ALERT 🚨".

Go ahead and try to edit the file!
