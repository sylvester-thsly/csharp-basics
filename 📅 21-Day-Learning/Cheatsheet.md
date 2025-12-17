# ⚡ C# Master Cheatsheet

## 📦 Variables & Data Types
```csharp
int age = 16;                   // Whole number
double price = 19.99;           // Decimal number
string name = "Sylvester";      // Text
char grade = 'A';               // Single character
bool isReady = true;            // True/False
```

## ➕ Operators
```csharp
int sum = 5 + 10;
int diff = 10 - 2;
int product = 5 * 5;
int division = 10 / 2;
int remainder = 10 % 3; // Returns 1

x++; // Increment (x = x + 1)
y--; // Decrement (y = y - 1)
```

## 🔀 Control Flow
### If / Else
```csharp
if (age >= 18) {
    Console.WriteLine("Adult");
} else {
    Console.WriteLine("Minor");
}
```

### Switch
```csharp
switch (day) {
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    default: Console.WriteLine("Unknown"); break;
}
```

## 🔁 Loops
### While Loop (Check then Run)
```csharp
while (lives > 0) {
    lives--;
}
```

### For Loop (Counted)
```csharp
for (int i = 0; i < 5; i++) {
    Console.WriteLine($"Count: {i}");
}
```

## 📋 Collections
### Arrays (Fixed Size)
```csharp
string[] names = new string[3];
names[0] = "Alice";
string[] fruits = { "Apple", "Banana" };
```

### Lists (Dynamic Size)
```csharp
List<string> todos = new List<string>();
todos.Add("Learn C#");
todos.Remove("Learn C#");
```

## 🔨 Methods
```csharp
// ReturnType Name(Parameters)
public int Add(int a, int b) {
    return a + b;
}

// Void returns nothing
public void SayHello() {
    Console.WriteLine("Hello!");
}
```

## 🏗️ Classes (OOP)
```csharp
public class Car {
    public string Model { get; set; } // Property
    
    public void Drive() {             // Method
        Console.WriteLine("Vroom!");
    }
}

// Usage
Car myCar = new Car();
myCar.Model = "BMW";
myCar.Drive();
```

## ⚠️ Error Handling
```csharp
try {
    int result = 10 / 0; // Crash!
} catch (DivideByZeroException ex) {
    Console.WriteLine("Cannot divide by zero!");
} finally {
    Console.WriteLine("This always runs.");
}
```
