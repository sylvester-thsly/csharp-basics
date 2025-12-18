# Day 9: Lists (Dynamic Collections)

## 📖 What You'll Learn
Lists are like **arrays that can grow and shrink**!

## 🎯 Arrays vs Lists

**Arrays:**
- Fixed size: `string[] fruits = new string[3];`
- Can't add more items after creation

**Lists:**
- Dynamic size: `List<string> fruits = new List<string>();`
- Can add/remove items anytime!

## 🧩 Key Concepts

### Creating a List
```csharp
List<string> names = new List<string>();
```

### Adding Items
```csharp
names.Add("Alice");
names.Add("Bob");
```

### Removing Items
```csharp
names.Remove("Alice");  // Remove by value
names.RemoveAt(0);      // Remove by index
```

### Accessing Items
```csharp
Console.WriteLine(names[0]);  // Same as arrays!
```

## ✅ Your Task
Open `Lists.cs` and complete the TODOs to practice Lists!
