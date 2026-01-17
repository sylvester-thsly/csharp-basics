# 📝 C# Fundamentals Exam (Tag 1-3)

**Total Points: 100**  
**Passing Score: 70/100**  
**Time Limit: No limit - Focus on understanding, not speed**

---

## Part 1: Multiple Choice (30 points, 3 points each)

### Question 1
What does CLR stand for?
- A) Common Language Runtime right 
- B) C# Language Runtime
- C) Code Level Runtime
- D) Compiled Language Runtime

### Question 2
Which is the correct entry point for a C# console application?
- A) `public void Main()` 
- B) `static void Main(string[] args)` this is right 
- C) `public static main()`  
- D) `void start()`

### Question 3
What is the output of this code?
```csharp
int x = 5;
double y = x;
Console.WriteLine(y); 
```
- A) Compiler error
- B) 5
- C) 5.0 this is right  
- D) Runtime error

### Question 4
Which suffix is required for a `float` literal?
- A) `d`
- B) `m`
- C) `f` this 
- D) No suffix needed

### Question 5
What is the size of an `int` in C#?
- A) 2 bytes
- B) 4 bytes this 
- C) 8 bytes
- D) Depends on the system

### Question 6
Which conversion is implicit (automatic)?
- A) `double` to `int`
- B) `int` to `short` 
- C) `int` to `long`
- D) `float` to `byte`

### Question 7
What does JIT stand for?
- A) Just In Time this 
- B) Java Integration Tool
- C) Jump Instruction Table
- D) Join Interface Type

### Question 8
Which type should you use for money calculations?
- A) `float`
- B) `double`
- C) `decimal`this 
- D) `int`

### Question 9
What is the default starting value for an enum?
- A) 1
- B) 0
- C) -1
- D) Must be specified
i dont know 



### Question 10
What does the escape sequence `\n` do?
- A) Creates a tab
- B) Creates a new line this 
- C) Adds a backslash
- D) Does nothing

---

## Part 2: True/False (20 points, 2 points each)

1. C# is case-sensitive. **[T/F]** T 
2. A variable can be used before it is initialized. **[T/F]** T
3. `byte` can store negative numbers. **[T/F]** F 
4. `const` variables can be changed after initialization. **[T/F]**T
5. IL code is platform-independent. **[T/F]**
6. `float` is more precise than `decimal`. **[T/F]** F
7. You can have multiple `Main` methods in one program. **[T/F]**
8. `char` uses Unicode encoding. **[T/F]** i dont know(What is unicode)
9. Implicit conversion can cause data loss. **[T/F]** i dont know 
10. The Garbage Collector manages memory automatically in C#. **[T/F]** T 

---

## Part 3: Code Analysis (20 points, 5 points each)

### Question 1
What is wrong with this code?
```csharp
int age;
Console.WriteLine(age);
```

### Question 2
What will this output?
```csharp
int x = 32768;
short y = (short)x;
Console.WriteLine(y);
```

### Question 3
Fix this code:
```csharp
decimal price = 19.99;
```

### Question 4
What happens when you run this?
```csharp
checked
{
    byte b = 255;
    b = b + 1;
}
```

---

## Part 4: Practical Coding (30 points, 10 points each)

### Task 1: Variable Declaration (10 points)
Create a program that declares and initializes:
- A constant for PI (3.14159)
- An integer for your age
- A string for your name
- A boolean for "isStudent"

Print all values to the console.

**File to create:** `Exam_Task1.cs`

---

### Task 2: Type Conversion (10 points)
Write a program that:
1. Declares a `double` variable with value `99.99`
2. Converts it to `int` (explicit cast)
3. Prints both the original and converted value
4. Explains in a comment why the values are different
double = 99.99 
i dont know how to do so 

**File to create:** `Exam_Task2.cs`

---

### Task 3: Enum Practice (10 points)
Create an enum called `DayOfWeek` with values Monday-Sunday.
Write a program that:
1. Declares a variable of type `DayOfWeek` set to Friday
2. Prints the name of the day
3. Prints the numeric value of the day

**File to create:** `Exam_Task3.cs`
enum = DayOfWeek 
DayOfWeek = Friday 
Console.WriteLine(DayOfWeek); 
Console.weiteLIne(5;)
---

## Submission Instructions

1. Create a folder: `Ausbildung-Journey/Exam-Tag1-3/`
2. Create a file `Answers.md` with your answers to Parts 1-3
3. Create the three `.cs` files for Part 4
4. Run each program and verify it works
5. Commit and push to GitHub

---

## Grading Rubric

- **90-100:** Excellent - Deep understanding
- **80-89:** Good - Solid grasp of concepts
- **70-79:** Pass - Basic understanding, needs practice
- **Below 70:** Review material and retake

---

**Good luck! Remember: If you get stuck, review your notes first. Learning is more important than the score.** 🚀
