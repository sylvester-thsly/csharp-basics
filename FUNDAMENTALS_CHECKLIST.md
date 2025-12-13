# 📋 C# Fundamentals Checklist

## ✅ = Completed | 🔄 = In Progress | ⏳ = Not Started

---

## 🟢 LEVEL 1: Absolute Basics (Week 1-2)

### Data Types & Variables
- [x] `int` - Whole numbers (1, 42, -10)
- [x] `double` - Decimal numbers (3.14, 0.002)
- [x] `string` - Text ("Hello", "LogisticsOS")
- [x] `bool` - True/False values
- [ ] `char` - Single characters ('A', '5')
- [ ] `decimal` - Precise decimals (for money)
- [ ] `var` keyword - Type inference
- [ ] Constants with `const`

### Operators
- [ ] Arithmetic: `+`, `-`, `*`, `/`, `%`
- [ ] Comparison: `==`, `!=`, `>`, `<`, `>=`, `<=`
- [ ] Logical: `&&` (AND), `||` (OR), `!` (NOT)
- [ ] Assignment: `=`, `+=`, `-=`, `*=`, `/=`
- [ ] Increment/Decrement: `++`, `--`

### Control Flow
- [ ] `if` statement
- [ ] `else` statement
- [ ] `else if` chains
- [ ] Ternary operator `? :`
- [ ] `switch` statement
- [ ] `switch` expressions (modern C#)

### Loops
- [ ] `for` loop
- [ ] `while` loop
- [ ] `do-while` loop
- [ ] `foreach` loop
- [ ] `break` keyword
- [ ] `continue` keyword

### Methods/Functions
- [x] Method declaration
- [x] Return types
- [x] Parameters
- [ ] Optional parameters
- [ ] Named parameters
- [ ] Method overloading
- [ ] `void` methods
- [ ] `return` keyword

---

## 🟡 LEVEL 2: Object-Oriented Programming (Week 3-4)

### Classes & Objects
- [x] Class definition
- [x] Properties with `{ get; set; }`
- [ ] Fields vs Properties
- [ ] Constructors
- [ ] `this` keyword
- [ ] Object instantiation with `new`
- [ ] Access modifiers: `public`, `private`, `protected`, `internal`
- [ ] `static` members
- [ ] `readonly` fields

### Collections
- [ ] Arrays: `int[]`, `string[]`
- [ ] `List<T>` - Dynamic arrays
- [ ] `Dictionary<TKey, TValue>` - Key-value pairs
- [ ] `HashSet<T>` - Unique values
- [ ] `Queue<T>` - First-in-first-out
- [ ] `Stack<T>` - Last-in-first-out
- [ ] Collection initializers

### Strings
- [ ] String concatenation
- [ ] String interpolation `$"Hello {name}"`
- [ ] `string.Format()`
- [ ] Common methods: `.Length`, `.ToUpper()`, `.ToLower()`, `.Trim()`
- [ ] `.Contains()`, `.StartsWith()`, `.EndsWith()`
- [ ] `.Split()`, `.Join()`
- [ ] `.Substring()`, `.Replace()`
- [ ] `StringBuilder` for performance

### Enums
- [ ] Enum declaration
- [ ] Enum values
- [ ] Enum parsing
- [ ] Enum flags

---

## 🔵 LEVEL 3: Intermediate Concepts (Week 5-6)

### LINQ (Language Integrated Query)
- [ ] `.Where()` - Filtering
- [ ] `.Select()` - Mapping/Projection
- [ ] `.OrderBy()` / `.OrderByDescending()`
- [ ] `.First()` / `.FirstOrDefault()`
- [ ] `.Any()` / `.All()`
- [ ] `.Count()` / `.Sum()` / `.Average()`
- [ ] `.Take()` / `.Skip()`
- [ ] `.GroupBy()`
- [ ] Method syntax vs Query syntax

### Error Handling
- [ ] `try-catch` blocks
- [ ] `finally` block
- [ ] `throw` keyword
- [ ] Custom exceptions
- [ ] Exception types: `ArgumentException`, `NullReferenceException`, etc.
- [ ] `using` statement for resource cleanup

### File I/O
- [ ] `File.ReadAllText()`
- [ ] `File.WriteAllText()`
- [ ] `File.ReadAllLines()`
- [ ] `File.Exists()`
- [ ] `Directory.CreateDirectory()`
- [ ] `Path.Combine()`
- [ ] `StreamReader` / `StreamWriter`

### Null Handling
- [ ] Null reference types
- [ ] `?` nullable value types
- [ ] `??` null-coalescing operator
- [ ] `?.` null-conditional operator
- [ ] `!` null-forgiving operator

---

## 🟣 LEVEL 4: Advanced Fundamentals (Week 7-8)

### Interfaces
- [ ] Interface declaration
- [ ] Implementing interfaces
- [ ] Multiple interface implementation
- [ ] Interface segregation

### Inheritance
- [ ] Base classes
- [ ] Derived classes
- [ ] `virtual` and `override` keywords
- [ ] `base` keyword
- [ ] `abstract` classes
- [ ] `sealed` classes

### Generics
- [ ] Generic methods
- [ ] Generic classes
- [ ] Type constraints with `where`
- [ ] `<T>` syntax

### Delegates & Events
- [ ] `Action<T>` delegate
- [ ] `Func<T>` delegate
- [ ] `Predicate<T>` delegate
- [ ] Lambda expressions `=>`
- [ ] Event declaration
- [ ] Event subscription

### Async Programming
- [ ] `async` keyword
- [ ] `await` keyword
- [ ] `Task` and `Task<T>`
- [ ] `async void` vs `async Task`
- [ ] `ConfigureAwait()`

---

## 🔴 LEVEL 5: Professional Skills (Week 9-12)

### Dependency Injection
- [ ] Constructor injection
- [ ] Service lifetimes: Singleton, Scoped, Transient
- [ ] `IServiceCollection`
- [ ] Registering services

### Entity Framework Core
- [ ] DbContext
- [ ] DbSet<T>
- [ ] Migrations
- [ ] CRUD operations
- [ ] Relationships (One-to-Many, Many-to-Many)
- [ ] Querying with LINQ

### ASP.NET Core Web API
- [ ] Controllers
- [ ] Action methods
- [ ] HTTP verbs: GET, POST, PUT, DELETE
- [ ] Route attributes
- [ ] Model binding
- [ ] `IActionResult` return types
- [ ] Middleware pipeline
- [ ] CORS configuration

### Testing
- [ ] Unit tests with xUnit
- [ ] Arrange-Act-Assert pattern
- [ ] Mocking with Moq
- [ ] Test-driven development (TDD)

### Design Patterns
- [ ] Repository pattern
- [ ] Factory pattern
- [ ] Singleton pattern
- [ ] Dependency Injection pattern
- [ ] Observer pattern

---

## 🎯 Practical Application Checklist

### Mini-Projects to Build
- [ ] **Calculator** - Practice methods and operators
- [ ] **To-Do List** - Practice collections and CRUD
- [ ] **Contact Manager** - Practice classes and file I/O
- [ ] **Bank Account System** - Practice OOP and encapsulation
- [ ] **Weather API Client** - Practice async/await and HTTP
- [ ] **Blog API** - Practice ASP.NET Core and EF Core
- [ ] **Authentication System** - Practice security concepts

---

## 📚 Concepts to Understand

### General Programming
- [ ] DRY (Don't Repeat Yourself)
- [ ] SOLID principles
- [ ] Separation of concerns
- [ ] Code organization
- [ ] Naming conventions
- [ ] Comments vs self-documenting code

### C# Specific
- [ ] Value types vs Reference types
- [ ] Stack vs Heap
- [ ] Garbage collection
- [ ] Boxing and unboxing
- [ ] Immutability
- [ ] Expression-bodied members

---

## 🔧 Tools & Environment

### Development Tools
- [x] Visual Studio Code setup
- [x] .NET SDK installation
- [ ] NuGet package manager
- [ ] Debugging with breakpoints
- [ ] Watch window
- [ ] Call stack understanding

### Version Control
- [x] Git basics (add, commit, push)
- [x] GitHub repository
- [ ] Branching and merging
- [ ] Pull requests
- [ ] .gitignore configuration
- [ ] Commit message conventions

### Command Line
- [x] `dotnet new` - Create projects
- [x] `dotnet run` - Run applications
- [x] `dotnet build` - Compile code
- [ ] `dotnet test` - Run tests
- [ ] `dotnet publish` - Prepare for deployment

---

## 📖 Resources for Each Topic

### When Stuck
1. **Microsoft Docs** - Official C# documentation
2. **Stack Overflow** - Community Q&A
3. **C# Discord** - Real-time help
4. **YouTube** - Visual explanations

### Practice Platforms
- **LeetCode** - Algorithm practice
- **HackerRank** - C# challenges
- **Exercism** - Mentored learning
- **Codewars** - Kata challenges

---

**Last Updated:** December 13, 2024  
**Progress:** 12 / 150+ concepts (8%)

*Check off items as you learn them. Update this file weekly!*
