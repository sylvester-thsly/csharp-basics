<div align="center">

# 🎓 C# Learning Journey: Zero to Full-Stack

### *Building Real Projects While Learning Fundamentals*

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![React](https://img.shields.io/badge/React-61DAFB?style=for-the-badge&logo=react&logoColor=black)
![Status](https://img.shields.io/badge/Level-Beginner-yellow?style=for-the-badge)
![Progress](https://img.shields.io/badge/Progress-Week_1-brightgreen?style=for-the-badge)

</div>

---

## 👋 About This Repository

This is my **learning-by-building** journey through C#. Instead of just doing tutorials, I'm creating a real logistics simulation platform to understand how professional software works.

**Age:** 16  
**Location:** Hamburg, Germany 🇩🇪  
**Goal:** Master C# before starting my IT Ausbildung in August 2026  
**Approach:** Learn → Build → Document → Repeat

---

## 📖 Learning Philosophy

> *"I don't just want to know the syntax. I want to understand how real developers think and build."*

This repo follows a **project-based learning** approach:
1. Learn a C# concept (variables, classes, APIs)
2. Immediately apply it to a real feature
3. Document what I learned
4. Move to the next concept

---

## 🗺️ Learning Roadmap

### 🟢 Phase 1: Fundamentals (Weeks 1-4) - **IN PROGRESS**

| Week | Topic | Status | Project Application |
|------|-------|--------|---------------------|
| **1** | Variables & Types | ✅ 80% | Created data models (`ShipmentRecord`) |
| **1** | Classes & Objects | ✅ 70% | Built `EmissionCalculator` class |
| **1** | Methods & Returns | ✅ 60% | API endpoints (`Calculate`, `GetHistory`) |
| **2** | Control Flow (if/else) | 🔄 20% | Validation logic |
| **2** | Loops (for/foreach) | ⏳ 0% | Processing collections |
| **3** | Collections (List, Array) | ⏳ 0% | Managing shipment history |
| **4** | Error Handling | ⏳ 0% | Try-catch blocks |

### � Phase 2: Intermediate (Weeks 5-8)

| Week | Topic | Status | Project Application |
|------|-------|--------|---------------------|
| **5** | File I/O | ⏳ | CSV import/export |
| **6** | LINQ Queries | ⏳ | Data filtering |
| **7** | Async/Await | ⏳ | API calls |
| **8** | Dependency Injection | ⏳ | Service architecture |

### 🔴 Phase 3: Advanced (Weeks 9-12)

| Week | Topic | Status | Project Application |
|------|-------|--------|---------------------|
| **9** | Entity Framework | ⏳ | Database ORM |
| **10** | Web APIs (ASP.NET) | ⏳ | REST endpoints |
| **11** | Authentication | ⏳ | Security |
| **12** | Deployment | ⏳ | Azure hosting |

---

## 🎯 Current Project: LogisticsOS

A web-based logistics operations dashboard that calculates CO2 emissions for shipments.

### What I've Built So Far

#### ✅ Backend (C# / ASP.NET Core)
- **Database Models** - Learned about classes and properties
  ```csharp
  public class ShipmentRecord {
      public int Id { get; set; }
      public double DistanceKm { get; set; }
      public double WeightKg { get; set; }
  }
  ```
- **Business Logic** - Created my first calculation method
  ```csharp
  public double CalculateCO2(double distance, double weight) {
      return distance * weight * 0.002;
  }
  ```
- **API Endpoints** - Learned how web servers respond to requests
  - `POST /api/emissions/calculate` - Accepts data, returns CO2
  - `GET /api/emissions/history` - Returns saved records

#### ✅ Frontend (React)
- Live feed showing real-time activity
- Terminal-style interface
- Interactive command line

#### ✅ Database (SQLite)
- Persistent storage for shipment records
- Learned about migrations and schema updates

---

## 📚 What I Learned This Week

### Day 1 (Dec 13, 2024)

#### Morning: C# Basics
- **Variables**: How to store data (`int`, `double`, `string`, `bool`)
- **Properties**: The `{ get; set; }` pattern
- **Classes**: Blueprints for objects
- **Methods**: Functions that do work

#### Afternoon: Building Features
- How to add a new field to a database
- What a "migration" is and why it matters
- How frontend and backend communicate (APIs)
- Git workflow (add, commit, push)

#### Key Breakthrough Moment
> *"I realized that `public bool IsPriority { get; set; }` is just creating a checkbox in memory. It's not complicated—it's just a labeled box!"*

---

## �️ Tech Stack

| Category | Technology | Why I Chose It |
|----------|-----------|----------------|
| **Language** | C# 12 | Industry standard, great for learning OOP |
| **Framework** | .NET 8 | Modern, cross-platform, well-documented |
| **Database** | SQLite | Simple file-based DB, perfect for learning |
| **Frontend** | React | Learn full-stack, not just backend |
| **IDE** | VS Code | Lightweight, great extensions |
| **Version Control** | Git/GitHub | Essential professional skill |

---

## 📊 Progress Tracking

### Skills Matrix

| Skill | Level | Evidence |
|-------|-------|----------|
| **Variables & Types** | ⭐⭐⭐⚪⚪ | Created `ShipmentRecord` with 5 properties |
| **Classes** | ⭐⭐⚪⚪⚪ | Built `EmissionCalculator` class |
| **Methods** | ⭐⭐⚪⚪⚪ | Wrote `CalculateCO2()` method |
| **Properties** | ⭐⭐⭐⚪⚪ | Understand `{ get; set; }` pattern |
| **APIs** | ⭐⚪⚪⚪⚪ | Created 2 endpoints (with guidance) |
| **Databases** | ⭐⚪⚪⚪⚪ | Ran migrations, understand tables |
| **Git** | ⭐⭐⚪⚪⚪ | Can commit, push, resolve conflicts |

### Time Investment
```
📅 Week 1 Progress
├── Monday (Dec 13)    : 6 hours ✅
├── Tuesday (Dec 14)   : Planned
├── Wednesday (Dec 15) : Planned
├── Thursday (Dec 16)  : Planned
└── Friday (Dec 17)    : Planned

Total: 6 / 20 hours (30%)
```

---

## 🎓 Learning Resources I'm Using

### Official Documentation
- 📖 [Microsoft C# Guide](https://learn.microsoft.com/dotnet/csharp/)
- � [ASP.NET Core Tutorials](https://learn.microsoft.com/aspnet/core/)

### Hands-On Practice
- 💻 Building this project (learning by doing)
- 🤖 AI pair programming for guidance
- � Writing documentation to solidify understanding

### Community
- 💬 GitHub for version control practice
- 📚 Stack Overflow for troubleshooting

---

## 🚀 How to Run This Project

### Prerequisites
```bash
# Check if you have .NET installed
dotnet --version  # Should show 8.0 or higher
```

### Setup
```bash
# 1. Clone the repository
git clone https://github.com/sylvester-thsly/csharp-basics.git
cd csharp-basics

# 2. Run the application
dotnet run --project Cargonerds.API --launch-profile http

# 3. Open your browser
http://localhost:5100
```

### Try It Out
1. The app will show a security screen (enter code: `KVKFKRCPNZQUYMLX` in Google Authenticator)
2. Type `help` in the terminal to see available commands
3. Type `sim start` to generate random shipment data
4. Watch the live feed update in real-time!

---

## 📝 Daily Learning Log

### December 13, 2024 - Day 1

**Topics Covered:**
- C# project structure
- Classes and properties
- Database models
- API endpoints
- Git basics

**Challenges:**
- Understanding `{ get; set; }` syntax (solved: it's just read/write permissions)
- Git merge conflicts (solved: learned about rebase)
- Database locked errors (solved: stop the app before migrations)

**Wins:**
- Built my first API endpoint that actually works!
- Successfully added a new database field (`IsPriority`)
- Pushed code to GitHub

**Tomorrow's Goals:**
- Complete the Priority feature (add visual indicator)
- Learn about `if` statements and conditionals
- Start Week 2 topics

---

## 🎯 Next Milestones

### This Week
- [ ] Finish Priority shipping feature
- [ ] Learn control flow (if/else/switch)
- [ ] Understand loops (for/foreach)
- [ ] Build a simple calculator method

### This Month
- [ ] Complete Phase 1 (Fundamentals)
- [ ] Build 3 mini-projects
- [ ] Write 5 blog posts about what I learned
- [ ] Contribute to an open-source C# project

### This Year (Before Ausbildung)
- [ ] Master C# fundamentals
- [ ] Build 10+ projects
- [ ] Learn ASP.NET Core deeply
- [ ] Deploy 3 apps to Azure
- [ ] Get comfortable with Git workflows

---

## � Why This Approach Works for Me

**Traditional Learning:**
- Read tutorial → Forget it in 2 days ❌

**My Approach:**
- Learn concept → Build feature → Explain it in README → Remember forever ✅

By documenting everything, I'm:
1. Reinforcing what I learned
2. Creating a reference for later
3. Showing my progress publicly
4. Building a portfolio

---

## 📫 Connect & Follow My Journey

[![GitHub](https://img.shields.io/badge/GitHub-sylvester--thsly-181717?style=for-the-badge&logo=github)](https://github.com/sylvester-thsly)

**Want to learn together?** Feel free to fork this repo and follow along!

---

<div align="center">

### 🔥 Day 1 Complete: From Zero to API in 6 Hours 🔥

**Last Updated:** December 13, 2024  
**Current Focus:** Week 1 - Variables & Classes

![Visitor Count](https://visitor-badge.laobi.icu/badge?page_id=sylvester-thsly.csharp-basics)

*"The best way to learn is to build something real."*

</div>
