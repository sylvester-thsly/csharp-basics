# Loops Explained: The "Repeat" Button

## 1. The `while` Loop
**Think of it as:** "Keep eating **while** there is pizza left."

You don't know exactly how many bites it will take, you just know the condition to stop.

```csharp
int pizzaSlices = 4;

while (pizzaSlices > 0)
{
    Console.WriteLine("Nom nom nom...");
    pizzaSlices--; // Ate one slice!
}
Console.WriteLine("Done!");
```

**Use it when:**
- You don't know how many times it needs to run.
- Example: "Keep asking for a password **while** the input is wrong."

## 2. The `for` Loop
**Think of it as:** "Do 10 pushups."

You know exactly how many to do.

```csharp
// Start at 1; Stop at 10; Go up by 1 step at a time
for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine("Pushup number " + i);
}
```

**The 3 Parts:**
1.  `int i = 1` -> **Start** (Where do we begin?)
2.  `i <= 10`   -> **Stop** (When do we end?)
3.  `i++`       -> **Step** (How much do we go up?)

**Use it when:**
- You know exactly how many times to repeat.
- You want to count numbers (1 to 100).
- You want to go through a specific list of items.
