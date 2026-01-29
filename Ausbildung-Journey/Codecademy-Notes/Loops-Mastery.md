# 🔄 The Power of Repetition: Loops

**Goal:** Automate boring tasks (like verifying 100 containers).

## 1. The While Loop
"Keep doing this WHILE the condition is true."

```csharp
while (fuel > 0)
{
    Drive();
    fuel--;
}
```

## 2. The Do-While Loop
"Do it at least ONCE, then check if we should continue."

```csharp
do 
{
    AskForPassword();
} 
while (password != "secret");
```

## 3. The For Loop
"Do this exactly X times."

```csharp
for (int i = 0; i < 100; i++)
{
    CheckContainer(i);
}
```
