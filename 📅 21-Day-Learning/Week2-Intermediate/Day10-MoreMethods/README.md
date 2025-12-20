# Day 10: Advanced Methods (Parameters & Return)

## 📖 What You'll Learn
Yesterday, we learned basic methods like `void SayHello()`.
Today, we make them smarter!

1.  **Parameters**: Passing data **INTO** a method.
2.  **Return Values**: Getting data **OUT** of a method.

## 🧩 Key Concepts

### 1. Parameters (Input)
```csharp
// "name" is a parameter
static void Greeting(string name) 
{
    Console.WriteLine("Hello, " + name);
}

// Call it:
Greeting("Sylvester"); // Prints: Hello, Sylvester
```

### 2. Return Values (Output)
Instead of `void` (which means nothing), we use a type like `int` or `string`.

```csharp
// Returns an integer
static int Add(int a, int b) 
{
    return a + b;
}

// Call it:
int result = Add(5, 3); // result is 8
```

## ✅ Your Task
Open `MoreMethods.cs` and complete the exercises to build a mini-calculator using methods!
