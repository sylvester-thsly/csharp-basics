# Common C# Mistakes & Fixes

## Beginner Mistakes I Made (and how to fix them)

### 1. Forgetting Semicolons
```csharp
// ❌ Wrong
int x = 5

// ✅ Correct
int x = 5;
```

### 1.5. Semicolons in Loops (The Daily Struggle)
```csharp
// ❌ Wrong - The semicolon kills the loop!
for (int i = 0; i < 10; i++);

// ✅ Correct - No semicolon here
for (int i = 0; i < 10; i++)
```

### 2. Wrong Method Call
```csharp
// ❌ Wrong - void methods don't return values
Console.WriteLine(Greet());

// ✅ Correct
Greet();
```

### 3. Integer Division
```csharp
// ❌ Wrong - gives 3
double result = 10 / 3;

// ✅ Correct - gives 3.333...
double result = (double)10 / 3;
```

### 4. List Type Declaration
```csharp
// ❌ Wrong
List tasks = new List();

// ✅ Correct - specify the type
List<string> tasks = new List<string>();
```

## Tips
- Always end statements with `;`
- Use `Console.ReadLine()` for input, not just `ReadLine()`
- Remember: `Main` with capital M, not `main`
